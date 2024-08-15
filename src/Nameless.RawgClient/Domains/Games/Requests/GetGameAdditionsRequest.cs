using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;
using Nameless.RawgClient.Domains.Games.Responses;

namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Request for a list of game's additions.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameAdditionsRequest([property: JsonProperty("id")] int Id)
        : Request<GetGameAdditionsResponse, Game>;
}
