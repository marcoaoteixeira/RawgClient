using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Genres.Requests {
    /// <summary>
    /// Represents a request object for genre's details.
    /// </summary>
    public sealed record GetGenreDetailsRequest : Request {
        /// <summary>
        /// Gets or init the genre's identifier.
        /// </summary>
        public int Id { get; init; }
    }
}
