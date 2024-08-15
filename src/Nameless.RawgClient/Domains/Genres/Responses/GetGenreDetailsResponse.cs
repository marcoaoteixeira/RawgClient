using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Genres.Objects;

namespace Nameless.RawgClient.Domains.Genres.Responses {
    /// <summary>
    /// Response for genre's details.
    /// </summary>
    public sealed record GetGenreDetailsResponse
        : Response<Genre>;
}
