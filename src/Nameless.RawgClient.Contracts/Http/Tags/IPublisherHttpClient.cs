using Nameless.RawgClient.Contracts.Http.Tags.Requests;
using Nameless.RawgClient.Contracts.Http.Tags.Responses;

namespace Nameless.RawgClient.Contracts.Http.Tags {
    /// <summary>
    /// Provides means to query tags endpoint.
    /// </summary>
    public interface ITagHttpClient {
        /// <summary>
        /// Get a list of game tags.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of tags.</returns>
        Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Get details of the tag.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A tag object with details.</returns>
        Task<GetTagDetailsResponse> GetTagDetailsAsync(GetTagDetailsRequest request, CancellationToken cancellationToken);
    }
}
