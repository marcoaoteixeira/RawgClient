using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Genres.Objects;
using Nameless.RawgClient.Domains.Genres.Responses;

namespace Nameless.RawgClient.Domains.Genres.Requests {
    /// <summary>
    /// Request for genre's details.
    /// </summary>
    /// <param name="Id">The genre's identifier.</param>
    public sealed record GetGenreDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetGenreDetailsResponse, Genre>;
}
