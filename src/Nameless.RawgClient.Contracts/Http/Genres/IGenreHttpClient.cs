using Nameless.RawgClient.Contracts.Http.Genres.Requests;
using Nameless.RawgClient.Contracts.Http.Genres.Responses;

namespace Nameless.RawgClient.Contracts.Http.Genres {
    /// <summary>
    /// Provides means to query genres endpoint.
    /// </summary>
    public interface IGenreHttpClient {
        /// <summary>
        /// Get a list of game genres.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of genres.</returns>
        Task<GetGenresResponse> GetGenresAsync(GetGenresRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Get details of the genre.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A genre object with details.</returns>
        Task<GetGenreDetailsResponse> GetGenreDetailsAsync(GetGenreDetailsRequest request, CancellationToken cancellationToken);
    }
}
