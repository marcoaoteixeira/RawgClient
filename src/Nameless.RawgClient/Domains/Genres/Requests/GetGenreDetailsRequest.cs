using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Genres.Objects;

namespace Nameless.RawgClient.Domains.Genres.Requests {
    /// <summary>
    /// Request for genre's details.
    /// </summary>
    /// <param name="Id">The genre's identifier.</param>
    public sealed record GetGenreDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Genre>;
}
