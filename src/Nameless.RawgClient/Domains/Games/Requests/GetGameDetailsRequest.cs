namespace Nameless.RawgClient.Domains.Games.Requests {
    /// <summary>
    /// Represents a request object for game's details.
    /// </summary>
    /// <param name="Id">Gets or init the game's identifier.</param>
    public sealed record GetGameDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetGameDetailsResponse, Game>;
}
