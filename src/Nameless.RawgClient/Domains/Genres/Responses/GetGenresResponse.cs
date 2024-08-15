using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Genres.Objects;

namespace Nameless.RawgClient.Domains.Genres.Responses {
    /// <summary>
    /// Response for a list of genres.
    /// </summary>
    public sealed record GetGenresResponse
        : Response<Genre>;
}
