using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nameless.RawgClient.Requests.Games;
using NLog.Extensions.Logging;

namespace Nameless.RawgClient.Consumer {
    public class EntryPoint {
        public static async Task Main(string[] args) {
            var services = new ServiceCollection();
            var configuration = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: false)
                         .Build();

            // enable logging if you wanna see what's going on with the HTTP client.
            services.AddLogging(configure => {
                configure.ClearProviders();
                configure.AddNLog(configuration);
            });

            // register IRawg service
            services.RegisterRawgClient(configure => {
                configure.ApiKey = "YOUR_API_KEY";
            });

            // build provider
            var provider = services.BuildServiceProvider();

            // resolve IRawg service
            var rawg = provider.GetRequiredService<IRawg>();

            // query the basic game list. check out namespace Nameless.RawgClient.Requests
            // for other types of request.
            var response = await rawg.QueryAsync(new GetGamesRequest {
                Search = "Doom"
            }, CancellationToken.None);

            if (!response.Succeeded) {
                Console.WriteLine($"Whoops...naughty client...: {response.Error}");
            }

            // iterate through the results.
            foreach (var result in response.Results) {
                Console.WriteLine($"Game: {result.Name}");
            }

            // Note: there are other properties in the response object.
            // Like
            //     - Previous: If not null, represents a previous request object
            //       that can be used to request previous results (paging)
            //
            //     - Next: same as "Previous", but for the next page case.
            //
            //     - Count: total results for the given request, don't confuse with
            //       total number of items in Results property.
            //
            //     - Results: the items returned by the request
            //
            //     - Success: If the request returned a success, meaning that it
            //       didn't fail or any error occurred.
            //
            //     - Error: If Success is false, you'll get a message stating what
            //       could be a root case of the problem.

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
