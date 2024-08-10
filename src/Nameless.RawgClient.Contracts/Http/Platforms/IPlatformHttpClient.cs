using Nameless.RawgClient.Contracts.Http.Platforms.Requests;
using Nameless.RawgClient.Contracts.Http.Platforms.Responses;

namespace Nameless.RawgClient.Contracts.Http.Platforms {
    /// <summary>
    /// Provides means to query platforms endpoint.
    /// </summary>
    public interface IPlatformHttpClient {
        /// <summary>
        /// Retrieves a list of game platforms.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of platforms.</returns>
        Task<GetPlatformsResponse> GetPlatformsAsync(GetPlatformsRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves details of the platform.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A platform object with details.</returns>
        Task<GetPlatformDetailsResponse> GetPlatformDetailsAsync(GetPlatformDetailsRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves a list of parent platforms.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A platform object with details.</returns>
        Task<GetParentPlatformsResponse> GetParentPlatformsAsync(GetParentPlatformsRequest request, CancellationToken cancellationToken);
    }
}
