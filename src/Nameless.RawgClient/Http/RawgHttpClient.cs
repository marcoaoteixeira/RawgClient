using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;
using OneOf;

namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient {
        private static readonly Action<ILogger, string, Exception?> JsonSerializationErrorLogger = LoggerMessage.Define<string>(
            logLevel: LogLevel.Error,
            eventId: default,
            formatString: "{Message}",
            options: null
        );

        private Uri BaseUri { get; }

        protected HttpClient CurrentHttpClient { get; }
        protected ILogger<RawgHttpClient> Logger { get; }

        public RawgHttpClient(HttpClient httpClient, ILogger<RawgHttpClient> logger) {
            CurrentHttpClient = Prevent.Null(httpClient, nameof(httpClient));
            BaseUri = Prevent.Null(CurrentHttpClient.BaseAddress, nameof(HttpClient.BaseAddress));
            Logger = Prevent.Null(logger, nameof(logger));
        }

        protected async Task<OneOf<TResult, ResponseError>> GetResultAsync<TResult>(string endpoint, Request request, CancellationToken cancellationToken)
            where TResult : class, new() {
            var currentEndpoint = Prevent.NullOrWhiteSpace(endpoint, nameof(endpoint));
            var currentQueryParams = request.ToQueryParams();
            var uri = EndpointHelper.CreateUri(baseUri: BaseUri,
                                               endpoint: currentEndpoint,
                                               queryParams: currentQueryParams);

            var sw = Stopwatch.StartNew();
            var response = await CurrentHttpClient.GetAsync(uri, cancellationToken)
                                                  .ConfigureAwait(continueOnCapturedContext: false);
            sw.Stop();
            Console.WriteLine($"Request time: {sw.ElapsedMilliseconds}ms");

            if (!response.IsSuccessStatusCode) {
                return new ResponseError(response.ReasonPhrase ?? response.StatusCode.ToString());
            }

            var json = await GetJsonResultAsync(response, cancellationToken);

            try { return JsonConvert.DeserializeObject<TResult>(json) ?? new TResult(); }
            catch (Exception ex) {
                const string message = "Error while deserializing JSON to response.";

                JsonSerializationErrorLogger(Logger, message, ex);

                return new ResponseError(message);
            }
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
    }
}
