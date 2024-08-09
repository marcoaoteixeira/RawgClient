using Nameless.RawgClient.Contracts.Http.Creators.Requests;
using Nameless.RawgClient.Contracts.Http.Creators.Responses;

namespace Nameless.RawgClient.Contracts.Http.Creators {
    /// <summary>
    /// Provides means to query creators endpoint.
    /// </summary>
    public interface ICreatorHttpClient {
        /// <summary>
        /// Get a list of game creators.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of creators.</returns>
        Task<GetCreatorsResponse> GetCreatorsAsync(GetCreatorsRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Get details of the creator.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A creator object with details.</returns>
        Task<GetCreatorDetailsResponse> GetCreatorDetailsAsync(GetCreatorDetailsRequest request, CancellationToken cancellationToken);
    }
}
