using Nameless.RawgClient.Common;
using Nameless.RawgClient.Infrastructure;

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
                throw new ArgumentNullException(nameof(HttpClient.BaseAddress), "HttpClient base address should be provided.");
            }
            _baseUri = new Uri(_httpClient.BaseAddress.AbsolutePath);
        }

        /// <inheritdoc />
        public async Task<TResponse> QueryAsync<TResponse, TResult>(Request<TResponse, TResult> request, CancellationToken cancellationToken)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            if (request is null) { throw new ArgumentNullException(nameof(request)); }

            // GetEndpoint endpoint based on request sent.
            var endpoint = _endpointProvider.GetEndpoint(request);

            // Let's "re-create" the request URI.
            var requestUri = CreateRequestUri(_baseUri, endpoint, request);

            // Call RAWG API endpoint
            HttpResponseMessage? httpResponseMessage;
            try {
                httpResponseMessage = await _httpClient.GetAsync(requestUri, cancellationToken)
                                                       .ConfigureAwait(continueOnCapturedContext: false);
            }
            catch (Exception ex) {
                ErrorLoggerHandler(_logger, "Error while calling API through HTTP client.", ex);
                return CreateErrorResponse<TResponse, TResult>("Call to RAWG API failed. See log files for more information.");
            }

            // If return anything other than success, let's return the response with an error message.
            if (!httpResponseMessage.IsSuccessStatusCode) {
                return CreateErrorResponse<TResponse, TResult>(httpResponseMessage.ReasonPhrase ?? httpResponseMessage.StatusCode.ToString());
            }

            // Extract the HTTP response content
            var content = await ExtractHttpMessageContentAsync(httpResponseMessage, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);

            // Now, let's try to get a JObject from the content extracted.
            JObject? obj;
            try {
                obj = JsonConvert.DeserializeObject<JObject>(content);
                if (obj is null) {
                    return CreateErrorResponse<TResponse, TResult>("Unable to proper deserialize JSON response.");
                }
            }
            catch (Exception ex) {
                ErrorLoggerHandler(_logger, $"Error while deserializing JSON to response ({typeof(TResponse)}).", ex);
                return CreateErrorResponse<TResponse, TResult>($"Error while deserializing JSON to response ({typeof(TResponse)}). See log files for more information.");
            }

            // Finally, return response.
            return CreateResponse(obj, request);
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

        // ReSharper disable once UnusedParameter.Local
        private static async Task<string> ExtractHttpMessageContentAsync(HttpResponseMessage response, CancellationToken cancellationToken) {
            var json = await response.Content
                                     .ReadAsStringAsync(cancellationToken)
                                     .ConfigureAwait(continueOnCapturedContext: false);
            return json;
        }

        private static TResponse CreateErrorResponse<TResponse, TResult>(string message)
            where TResponse : Response<TResult>, new()
            where TResult : class
            => new() { Error = message };

        private static TResponse CreateResponse<TResponse, TResult>(JObject obj, Request<TResponse, TResult> request)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            try {
                var count = obj.TryGetValue("count", out var countToken)
                        ? countToken.ToObject<int>()
                        : 0;

                var previous = obj.TryGetValue("previous", out var previousToken)
                    ? previousToken.ToObject<string>()
                    : null;

                var next = obj.TryGetValue("next", out var nextToken)
                    ? nextToken.ToObject<string>()
                    : null;

                TResult[] results;
                if (!obj.TryGetValue("results", out var resultsToken)) {
                    // If it doesn't contain the key "results", it means it's just one item.
                    // This unique item will reside in the root object.
                    var item = obj.ToObject<TResult>();
                    results = item is not null ? [item] : [];

                    // Update count property
                    count = results.Length;
                }
                else {
                    // If it contains the key "results", it means that this is a page of items.
                    // We'll leave count unchanged because the count value represents
                    // the total number of possible results for this query.
                    results = resultsToken.ToObject<TResult[]>() ?? [];
                }

                return new TResponse {
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
                return CreateErrorResponse<TResponse, TResult>($"Error while creating response. {ex.Message}");
            }
        }
    }
}
