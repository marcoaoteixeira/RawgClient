namespace Nameless.RawgClient.Domains.Tags.Requests {
    /// <summary>
    /// Represents a request object for tag's details.
    /// </summary>
    /// <param name="Id">The tag identifier.</param>
    public sealed record GetTagDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetTagDetailsResponse, Tag>;
}
