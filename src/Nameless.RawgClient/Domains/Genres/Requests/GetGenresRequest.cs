namespace Nameless.RawgClient.Domains.Genres.Requests {
    /// <summary>
    /// Represents a request object for a list of genre.
    /// </summary>
    public sealed record GetGenresRequest
        : Request<GetGenresResponse, Genre>;
}
