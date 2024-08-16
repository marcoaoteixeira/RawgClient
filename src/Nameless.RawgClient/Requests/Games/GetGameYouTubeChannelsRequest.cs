using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Games {
    /// <summary>
    /// Request for a list of game's YouTube channels.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameYouTubeChannelsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Game>;
}
