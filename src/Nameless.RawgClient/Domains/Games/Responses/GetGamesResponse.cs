using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;

namespace Nameless.RawgClient.Domains.Games.Responses {
    /// <summary>
    /// Response for a list of games.
    /// </summary>
    public record GetGamesResponse
        : Response<Game>;
}
