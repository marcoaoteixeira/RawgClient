using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;

namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Request for game's details.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Game>;
}
