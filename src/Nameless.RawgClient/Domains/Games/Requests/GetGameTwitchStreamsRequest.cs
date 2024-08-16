using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;

namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Request for a list of game's Twitch streams.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameTwitchStreamsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Game>;
}
