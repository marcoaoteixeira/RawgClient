using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;
using Nameless.RawgClient.Domains.Games.Responses;

namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Request for a list of games.
    /// </summary>
    public record GetGamesRequest
        : Request<GetGamesResponse, Game>;
}
