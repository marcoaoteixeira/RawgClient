using System.Diagnostics;
using System.Text.Json.Nodes;
using Nameless.RawgClient.Common;
using Nameless.RawgClient.Infrastructure;
using Nameless.RawgClient.Json.Converters;

namespace Nameless.RawgClient.Impl {
    /// <summary>
    /// Current implementation of <see cref="IRawg"/>.
    /// </summary>
    public sealed class Rawg : IRawg {
        private static readonly Action<ILogger, string, Exception?> ErrorLoggerHandler = LoggerMessage.Define<string>(
            logLevel: LogLevel.Error,
            eventId: default,
            formatString: "{Message}",
            options: null
        );

        private static readonly Action<ILogger, string, long, Exception?> RunTimeLoggerHandler = LoggerMessage.Define<string, long>(
            logLevel: LogLevel.Information,
            eventId: default,
            formatString: "Operation: {Operation} took {Time}ms",
            options: null
        );

        private static readonly JsonSerializerOptions SerializerOptions = new() {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            Converters = {
                new NullToDateTimeOffsetJsonConverter(),
                new NullToDoubleJsonConverter(),
                new NullToIntJsonConverter(),
                new OrderingJsonConverter(),
                new ReactionCollectionJsonConverter(),
                new TrailerOptionCollectionJsonConverter(),
            }
        };

        private readonly HttpClient _httpClient;
        private readonly IEndpointProvider _endpointProvider;
        private readonly ILogger<Rawg> _logger;
        private readonly Uri _baseUri;

        /// <summary>
        /// Initializes a new instance of <see cref="Rawg"/>.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="endpointProvider">The endpoint provider.</param>
        /// <param name="logger">The logger.</param>
        /// <exception cref="ArgumentNullException">if
        /// <paramref name="httpClient"/> or
        /// <paramref name="endpointProvider"/> or
        /// <paramref name="logger"/> or
        /// value of <see cref="HttpClient.BaseAddress"/> is <c>null</c>.
        /// </exception>
        public Rawg(HttpClient httpClient, IEndpointProvider endpointProvider, ILogger<Rawg> logger) {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _endpointProvider = endpointProvider ?? throw new ArgumentNullException(nameof(endpointProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            if (_httpClient.BaseAddress is null) {
                throw new ArgumentException("HttpClient base address should be provided.");
            }

            _baseUri = new Uri(_httpClient.BaseAddress.AbsoluteUri);
        }

        /// <inheritdoc />
        public async Task<Response<TResult>> QueryAsync<TResult>(Request<TResult> request, CancellationToken cancellationToken)
            where TResult : class {
            ArgumentNullException.ThrowIfNull(request, nameof(request));

            // GetEndpoint endpoint based on request sent.
            var endpoint = _endpointProvider.GetEndpoint(request);

            // Let's "re-create" the request URI.
            var requestUri = CreateRequestUri(_baseUri, endpoint, request);

            // Call RAWG API endpoint
            HttpResponseMessage? httpResponseMessage;
            try {
                var sw = Stopwatch.StartNew();

                httpResponseMessage = await _httpClient.GetAsync(requestUri, cancellationToken)
                                                       .ConfigureAwait(continueOnCapturedContext: false);

                sw.Stop();

                RunTimeLoggerHandler(_logger, "Call to RAWG API", sw.ElapsedMilliseconds, null);
            }
            catch (Exception ex) {
                return CreateErrorResponse<TResult>("Call to RAWG API failed.", ex);
            }

            // If return anything other than success, let's return the response with an error message.
            if (!httpResponseMessage.IsSuccessStatusCode) {
                return CreateErrorResponse<TResult>(httpResponseMessage.ReasonPhrase ?? httpResponseMessage.StatusCode.ToString());
            }

            // Extract the HTTP response content
            var content = await ExtractHttpMessageContentAsync(httpResponseMessage, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);

            // Now, let's try to get a JObject from the content extracted.
            JsonObject? obj;
            try {
                obj = JsonSerializer.Deserialize<JsonObject>(content);
                if (obj is null) {
                    return CreateErrorResponse<TResult>("Unable to proper deserialize JSON response.");
                }
            }
            catch (Exception ex) {
                return CreateErrorResponse<TResult>("Error while deserializing JSON to response.", ex);
            }

            // Finally, return response.
            return CreateResponse(obj, request);
        }

        // ReSharper disable once UnusedParameter.Local
        private static async Task<string> ExtractHttpMessageContentAsync(HttpResponseMessage response, CancellationToken cancellationToken) {
            var json = await response.Content
                                     .ReadAsStringAsync(cancellationToken)
                                     .ConfigureAwait(continueOnCapturedContext: false);
            return json;
        }

        private static string CreateRequestUri(Uri baseUri, string endpoint, Request request) {
            var builder = new UriBuilder(baseUri) { Path = endpoint, };
            var queryString = HttpUtility.ParseQueryString(baseUri.Query);
            foreach (var queryParam in request.GetQueryParams()) {
                queryString.Add(name: queryParam.Key,
                                value: string.Join(',', queryParam.Value));
            }

            builder.Query = queryString.ToString();

            return builder.Uri.AbsoluteUri;
        }

        private Response<TResult> CreateResponse<TResult>(JsonObject obj, Request<TResult> request)
            where TResult : class {
            try {
                // Note: TryGetPropertyValue do not return what I was expecting.
                // It returns a JsonNode to the property (if it's present in
                // JSON). From there, you need to call JsonNode.GetValue<T> to
                // get the actual value. If null, it will throw an exception.
                // To avoid that, I create two extension methods to get int or
                // string without this exception thing side effect.
                // Also, TryGetPropertyValue do not annotate the output JsonNode
                // with NotNullWhenAttribute. Making the design time unaware that
                // the property is not null if TryGetPropertyValue returns true,
                // adding that squiggling line (possible null reference) under
                // the output variable if you try to call any method/property.

                var count = obj.TryGetPropertyValue("count", out var countToken)
                    ? countToken.GetIntValue()
                    : 0;

                var previous = obj.TryGetPropertyValue("previous", out var previousToken)
                    ? previousToken.GetStringValue()
                    : null;

                var next = obj.TryGetPropertyValue("next", out var nextToken)
                    ? nextToken.GetStringValue()
                    : null;

                TResult[] results;
                if (obj.TryGetPropertyValue("results", out var resultsToken)) {
                    // If it contains the key "results", it means that this is a page of items.
                    // We'll leave count unchanged because the count value represents
                    // the total number of possible results for this query.
                    results = resultsToken.DeserializeWithFallback<TResult[]>(fallback: () => [], options: SerializerOptions);
                }
                else {
                    // If it doesn't contain the key "results", it means it's just one item.
                    // This unique item will reside in the root object.
                    var item = obj.Deserialize<TResult>(options: SerializerOptions);
                    results = item is not null ? [item] : [];

                    // Update count property
                    count = results.Length;
                }

                return new Response<TResult> {
                    Count = count,
                    Results = results,

                    // nice feature of record object, "with" keyword.
                    Previous = previous is not null
                        ? request with { PageNumber = request.PageNumber - 1 }
                        : null,
                    Next = next is not null
                        ? request with { PageNumber = request.PageNumber + 1 }
                        : null
                };
            }
            catch (Exception ex) {
                return CreateErrorResponse<TResult>("Error while creating response.", ex);
            }
        }

        private Response<TResult> CreateErrorResponse<TResult>(string message, Exception? exception = null)
            where TResult : class {
            ErrorLoggerHandler(_logger, message, exception);

            return new Response<TResult> { Error = $"{message} (See log file for more information)" };
        }
    }
}
