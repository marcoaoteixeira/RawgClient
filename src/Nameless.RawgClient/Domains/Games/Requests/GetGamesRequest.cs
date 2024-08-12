namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Represents a request object for a list of game.
    /// </summary>
    public sealed record GetGamesRequest
        : Request<GetGamesResponse, Game>;
}
