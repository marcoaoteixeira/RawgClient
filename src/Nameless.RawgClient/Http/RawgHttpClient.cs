using System.Web;
using Microsoft.Extensions.Logging;
using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;
using OneOf;

namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient {
        private static readonly Action<ILogger, string, Exception?> HttpClientCallErrorLogger = LoggerMessage.Define<string>(
            logLevel: LogLevel.Error,
            eventId: default,
            formatString: "{Message}",
            options: null
        );

        private static readonly Action<ILogger, string, Exception?> JsonSerializationErrorLogger = LoggerMessage.Define<string>(
            logLevel: LogLevel.Error,
            eventId: default,
            formatString: "{Message}",
            options: null
        );

        private Uri BaseUri { get; }
        private HttpClient CurrentHttpClient { get; }
        private ILogger<RawgHttpClient> Logger { get; }

        public RawgHttpClient(HttpClient httpClient, ILogger<RawgHttpClient> logger) {
            CurrentHttpClient = Prevent.Null(httpClient, nameof(httpClient));
            BaseUri = Prevent.Null(CurrentHttpClient.BaseAddress, nameof(HttpClient.BaseAddress));
            Logger = Prevent.Null(logger, nameof(logger));
        }

        protected async Task<OneOf<TResult, ResponseError>> GetResultAsync<TResult>(string endpoint, Request request, CancellationToken cancellationToken)
            where TResult : class, new() {
            var requestUri = CreateRequestUri(BaseUri, endpoint, request);

            var call = await CallEndpointAsync(requestUri, cancellationToken);

            return call.Match(
                httpResponse => async () {
                    var json = await GetJsonResultAsync(response, cancellationToken);

                    return DeserializeObject<TResult>(json);
                },
                error => error
            );

            
        }

        private OneOf<TResult, ResponseError> DeserializeObject<TResult>(string json)
            where TResult : class, new() {
            try { return JsonConvert.DeserializeObject<TResult>(json) ?? new TResult(); }
            catch (Exception ex) {
                const string message = "Error while deserializing JSON to response.";

                JsonSerializationErrorLogger(Logger, message, ex);

                return new ResponseError(message);
            }
        }

        private static string CreateRequestUri(Uri baseUri, string endpoint, Request request) {
            var builder = new UriBuilder(baseUri) {
                Path = endpoint,
            };

            var queryString = HttpUtility.ParseQueryString(baseUri.Query);
            foreach (var queryParam in request.ToQueryParams()) {
                queryString.Add(name: queryParam.Key,
                                value: string.Join(',', queryParam.Value));
            }
            builder.Query = queryString.ToString();

            return builder.Uri.AbsoluteUri;
        }

        private async Task<OneOf<HttpResponseMessage, ResponseError>> CallEndpointAsync(string requestUri, CancellationToken cancellationToken) {
            HttpResponseMessage? response;
            try {
                response = await CurrentHttpClient.GetAsync(requestUri, cancellationToken)
                                                  .ConfigureAwait(continueOnCapturedContext: false);
            }
            catch (Exception ex) {
                const string message = "Error while calling API through HTTP client.";

                HttpClientCallErrorLogger(Logger, message, ex);

                return new ResponseError($"{message} See log file for more information.");
            }

            if (!response.IsSuccessStatusCode) {
                return new ResponseError(response.ReasonPhrase ?? response.StatusCode.ToString());
            }

            return response;
        }

        private static async Task<string> GetJsonResultAsync(HttpResponseMessage response, CancellationToken cancellationToken) {
            var json = await response.Content
#if NET6_0_OR_GREATER
                                     .ReadAsStringAsync(cancellationToken)
#elif NETSTANDARD2_1
                                     .ReadAsStringAsync()
#endif
                                     .ConfigureAwait(continueOnCapturedContext: false);
            return json;
        }

        private static TResponse CreateResponse<TRequest, TResponse, TResult>(TRequest request, OneOf<Paginable<TResult>, ResponseError> result)
            where TRequest : PaginableRequest
            where TResponse : PaginableResponse<TResult>, new()
            where TResult : class {
            return result.Match(
                success => success.CreateResponse<TResponse>(request),
                error => new TResponse { Error = error.Reason }
            );
        }

        private static TResponse CreateResponse<TResponse, TResult>(OneOf<TResult, ResponseError> result)
            where TResponse : Response<TResult>, new()
            where TResult : class {
            return result.Match(
                success => new TResponse { Results = [success] },
                error => new TResponse { Error = error.Reason }
            );
        }
    }
}
