using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Genres.Requests {
    /// <summary>
    /// Represents a request object for a list of genre.
    /// </summary>
    public sealed record GetGenresRequest : PaginableRequest;
}
