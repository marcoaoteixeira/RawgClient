using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Nameless.RawgClient.Http;
using Nameless.RawgClient.Options;

namespace Nameless.RawgClient {
    /// <summary>
    /// <see cref="IServiceCollection"/> extension methods.
    /// </summary>
    public static class ServiceCollectionExtension {
        private const string RawgHttpClientKey = $"{nameof(RawgHttpClient)}::64b28d0b-f17c-4cbf-a515-58500b6b20c2";

        /// <summary>
        /// Registers RAWG Client infrastructure and enable use of all HTTP clients defined by this assembly.
        /// </summary>
        /// <param name="self">The current <see cref="IServiceCollection"/> instance.</param>
        /// <param name="configure">A configuration delegate.</param>
        /// <returns>The current <see cref="IServiceCollection"/>, so other services registrations can be chained.</returns>
        public static IServiceCollection RegisterRawgClient(this IServiceCollection self, Action<RawgOptions>? configure = null) {
            self.AddHttpClient(RawgHttpClientKey);

            self.AddKeyedScoped(
                serviceKey: RawgHttpClientKey,
                implementationFactory: (provider, key) => {
                    var httpClient = provider.GetRequiredService<IHttpClientFactory>()
                                             .CreateClient(RawgHttpClientKey);
                    var logger = GetLogger<RawgHttpClient>(provider);
                    var options = provider.GetRequiredService<IConfiguration>()
                                          .GetSection(nameof(RawgOptions))
                                          .Get<RawgOptions>() ?? RawgOptions.Default;

                    ConfigureHttpClient(configure, options, httpClient);

                    return new RawgHttpClient(httpClient, logger);
                });

            self
                .AddScoped<ICreatorRoleHttpClient>(ResolveRawgHttpClient)
                .AddScoped<ICreatorHttpClient>(ResolveRawgHttpClient)
                .AddScoped<IDeveloperHttpClient>(ResolveRawgHttpClient)
                .AddScoped<IGenreHttpClient>(ResolveRawgHttpClient);

            return self;
        }

        private static void ConfigureHttpClient(Action<RawgOptions>? configure, RawgOptions options, HttpClient httpClient) {
            configure?.Invoke(options);

            var baseUri = new UriBuilder {
                Scheme = options.Scheme,
                Host = options.Host,
                Port = options.Port,
                Query = $"key={options.ApiKey}"
            }.Uri;

            httpClient.BaseAddress = baseUri;
        }

        private static RawgHttpClient ResolveRawgHttpClient(IServiceProvider provider)
            => provider.GetRequiredKeyedService<RawgHttpClient>(RawgHttpClientKey);

        private static ILogger<T> GetLogger<T>(IServiceProvider provider) {
            var loggerFactory = provider.GetService<ILoggerFactory>();
            var logger = loggerFactory is not null
                ? loggerFactory.CreateLogger<T>()
                : NullLogger<T>.Instance;

            return logger;
        }
    }
}
