namespace Nameless.RawgClient.Domains.Genres.Requests {
    /// <summary>
    /// Represents a request object for genre's details.
    /// </summary>
    /// <param name="Id">Gets or init the genre's identifier.</param>
    public sealed record GetGenreDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetGenreDetailsResponse, Genre>;
}
