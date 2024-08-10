using Nameless.RawgClient.Contracts.Http.Stores.Requests;
using Nameless.RawgClient.Contracts.Http.Stores.Responses;

namespace Nameless.RawgClient.Contracts.Http.Stores {
    /// <summary>
    /// Provides means to query stores endpoint.
    /// </summary>
    public interface IStoreHttpClient {
        /// <summary>
        /// Get a list of game stores.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of stores.</returns>
        Task<GetStoresResponse> GetStoresAsync(GetStoresRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Get details of the store.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A store object with details.</returns>
        Task<GetStoreDetailsResponse> GetStoreDetailsAsync(GetStoreDetailsRequest request, CancellationToken cancellationToken);
    }
}
