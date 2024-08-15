using Nameless.RawgClient.Impl;
using Nameless.RawgClient.Infrastructure;
using Nameless.RawgClient.Infrastructure.Impl;
using Nameless.RawgClient.Options;

namespace Nameless.RawgClient {
    /// <summary>
    /// <see cref="IServiceCollection"/> extension methods.
    /// </summary>
    public static class ServiceCollectionExtension {
        private const string RawgKey = $"{nameof(Rawg)}::64b28d0b-f17c-4cbf-a515-58500b6b20c2";
        private const string EndpointProviderKey = $"{nameof(EndpointProvider)}::19ccfcb6-74eb-41c6-8f07-219abe66ce38";

        /// <summary>
        /// Registers RAWG Client.
        /// </summary>
        /// <param name="self">The current <see cref="IServiceCollection"/> instance.</param>
        /// <param name="configure">A configuration delegate.</param>
        /// <returns>The current <see cref="IServiceCollection"/>, so other services registrations can be chained.</returns>
        public static IServiceCollection RegisterRawgClient(this IServiceCollection self, Action<RawgOptions>? configure = null) {
            self.AddHttpClient(RawgKey);

            self.AddKeyedSingleton<IEndpointProvider, EndpointProvider>(EndpointProviderKey);

            self.AddScoped(provider => {
                var httpClient = provider.GetRequiredService<IHttpClientFactory>()
                                         .CreateClient(RawgKey);
                var endpointProvider = provider.ResolveEndpointProvider();
                var logger = provider.ResolveLogger<Rawg>();
                var options = provider.ResolveOptions<RawgOptions>();

                ConfigureHttpClient(configure, httpClient, options);

                return new Rawg(httpClient, endpointProvider, logger);
            });

            return self;
        }

        private static void ConfigureHttpClient(Action<RawgOptions>? configure, HttpClient httpClient, RawgOptions options) {
            configure?.Invoke(options);

            var baseUri = new UriBuilder {
                Scheme = options.Scheme,
                Host = options.Host,
                Port = options.Port,
                Query = $"key={options.ApiKey}"
            }.Uri;

            httpClient.BaseAddress = baseUri;
        }

        private static ILogger<T> ResolveLogger<T>(this IServiceProvider provider) {
            var loggerFactory = provider.GetService<ILoggerFactory>();
            var logger = loggerFactory is not null
                ? loggerFactory.CreateLogger<T>()
                : NullLogger<T>.Instance;

            return logger;
        }

        private static TOptions ResolveOptions<TOptions>(this IServiceProvider provider)
            where TOptions : class, new() {
            var options = provider.GetService<IOptions<TOptions>>();

            return options?.Value ?? new TOptions();
        }

        private static IEndpointProvider ResolveEndpointProvider(this IServiceProvider provider)
            => provider.GetRequiredKeyedService<IEndpointProvider>(EndpointProviderKey);
    }
}
