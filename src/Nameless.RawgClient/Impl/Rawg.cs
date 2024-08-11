namespace Nameless.RawgClient.Impl {
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

        public Rawg(HttpClient httpClient, IEndpointProvider endpointProvider, ILogger<Rawg> logger) {
            _httpClient = Prevent.Null(httpClient, nameof(httpClient));
            _endpointProvider = Prevent.Null(endpointProvider, nameof(endpointProvider));
            _logger = Prevent.Null(logger, nameof(logger));
            _baseUri = Prevent.Null(_httpClient.BaseAddress, nameof(HttpClient.BaseAddress));
        }

        public async Task<TResponse> QueryAsync<TResponse, TResult>(Request<TResponse, TResult> request, CancellationToken cancellationToken)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            Prevent.Null(request, nameof(request));

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
                return Error<TResponse, TResult>("Call to RAWG API failed. See log files for more information.");
            }

            // If return anything other than success, let's return the response with an error message.
            if (!httpResponseMessage.IsSuccessStatusCode) {
                return Error<TResponse, TResult>(httpResponseMessage.ReasonPhrase ?? httpResponseMessage.StatusCode.ToString());
            }

            // Extract the HTTP response content
            var content = await ExtractHttpMessageContentAsync(httpResponseMessage, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);

            // Now, let's try to get a JObject from the content extracted.
            JToken? token;
            try {
                token = JsonConvert.DeserializeObject<JToken>(content);
                if (token is null) {
                    return Error<TResponse, TResult>("Unable to proper deserialize JSON response.");
                }
            }
            catch (Exception ex) {
                ErrorLoggerHandler(_logger, $"Error while deserializing JSON to response ({typeof(TResponse)}).", ex);
                return Error<TResponse, TResult>($"Error while deserializing JSON to response ({typeof(TResponse)}). See log files for more information.");
            }

            // Finally, return response.
            return CreateResponse(token, request);
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
#if NET6_0_OR_GREATER
                                     .ReadAsStringAsync(cancellationToken)
#elif NETSTANDARD2_1
                                     .ReadAsStringAsync()
#endif
                                     .ConfigureAwait(continueOnCapturedContext: false);
            return json;
        }

        private static TResponse Error<TResponse, TResult>(string message)
            where TResponse : Response<TResult>, new()
            where TResult : class
            => new() { Error = message };

        private static TResponse CreateResponse<TResponse, TResult>(JToken token, Request<TResponse, TResult> request)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            return IsPaginable(token)
                ? CreateResponseFromPaginable(token, request)
                : CreateResponseFromSingleItem<TResponse, TResult>(token);

            static bool IsPaginable(JToken token)
                => token is JObject obj &&
                   obj.ContainsKey("count") &&
                   obj.ContainsKey("results");
        }

        private static TResponse CreateResponseFromPaginable<TResponse, TResult>(JToken token, Request<TResponse, TResult> request)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            var paginable = token.ToObject<Paginable<TResult>>();
            if (paginable is null) {
                return Error<TResponse, TResult>("Unable to proper deserialize JSON response.");
            }

            return new TResponse {
                Count = paginable.Count,
                Results = paginable.Results,
                Previous = paginable.PreviousQuery is not null
                    ? request with { PageNumber = request.PageNumber - 1 }
                    : null,
                Next = paginable.NextQuery is not null
                    ? request with { PageNumber = request.PageNumber + 1 }
                    : null
            };
        }

        private static TResponse CreateResponseFromSingleItem<TResponse, TResult>(JToken token)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            var single = token.ToObject<TResult>();
            if (single is null) {
                return Error<TResponse, TResult>("Unable to proper deserialize JSON response.");
            }

            return new TResponse {
                Count = 1,
                Results = [single]
            };
        }
    }
}
