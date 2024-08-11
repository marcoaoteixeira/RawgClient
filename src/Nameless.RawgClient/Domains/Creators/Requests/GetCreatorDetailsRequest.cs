namespace Nameless.RawgClient.Domains.Creators.Requests {
    /// <summary>
    /// Request object used to retrieve a creator by its identifier.
    /// </summary>
    /// <param name="Id">Gets or init the identifier.</param>
    public sealed record GetCreatorDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetCreatorDetailsResponse, Creator>;
}
