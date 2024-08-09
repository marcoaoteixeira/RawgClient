using Nameless.RawgClient.Contracts.Http.Publishers.Requests;
using Nameless.RawgClient.Contracts.Http.Publishers.Responses;

namespace Nameless.RawgClient.Contracts.Http.Publishers {
    /// <summary>
    /// Provides means to query publishers endpoint.
    /// </summary>
    public interface IPublisherHttpClient {
        /// <summary>
        /// Get a list of game publishers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of publishers.</returns>
        Task<GetPublishersResponse> GetPublishersAsync(GetPublishersRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Get details of the publisher.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A publisher object with details.</returns>
        Task<GetPublisherDetailsResponse> GetPublisherDetailsAsync(GetPublisherDetailsRequest request, CancellationToken cancellationToken);
    }
}
