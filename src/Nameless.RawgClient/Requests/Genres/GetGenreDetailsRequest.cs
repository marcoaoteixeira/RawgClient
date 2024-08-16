using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Genres {
    /// <summary>
    /// Request for genre's details.
    /// </summary>
    /// <param name="Id">The genre's identifier.</param>
    public sealed record GetGenreDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Genre>;
}
