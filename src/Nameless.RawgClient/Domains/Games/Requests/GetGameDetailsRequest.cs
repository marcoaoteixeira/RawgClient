using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;
using Nameless.RawgClient.Domains.Games.Responses;

namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Request for game's details.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetGameDetailsResponse, Game>;
}
