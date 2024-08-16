using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Genres {
    /// <summary>
    /// Request object for a list of genre.
    /// </summary>
    public sealed record GetGenresRequest
        : Request<Genre>;
}
