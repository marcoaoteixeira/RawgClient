using Nameless.RawgClient.Contracts.Http.Developers.Requests;
using Nameless.RawgClient.Contracts.Http.Developers.Responses;

namespace Nameless.RawgClient.Contracts.Http.Developers {
    /// <summary>
    /// Provides means to query developers endpoint.
    /// </summary>
    public interface IDeveloperHttpClient {
        /// <summary>
        /// Get a list of game developers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of developers.</returns>
        Task<GetDevelopersResponse> GetDevelopersAsync(GetDevelopersRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Get details of the developer.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A developer object with details.</returns>
        Task<GetDeveloperDetailsResponse> GetDeveloperDetailsAsync(GetDeveloperDetailsRequest request, CancellationToken cancellationToken);
    }
}
