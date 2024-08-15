using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Genres.Objects;
using Nameless.RawgClient.Domains.Genres.Responses;

namespace Nameless.RawgClient.Domains.Genres.Requests {
    /// <summary>
    /// Request object for a list of genre.
    /// </summary>
    public sealed record GetGenresRequest
        : Request<GetGenresResponse, Genre>;
}
