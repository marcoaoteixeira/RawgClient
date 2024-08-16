using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;

namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Request for a list of game's similar suggestions.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameSuggestionsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Game>;
}
