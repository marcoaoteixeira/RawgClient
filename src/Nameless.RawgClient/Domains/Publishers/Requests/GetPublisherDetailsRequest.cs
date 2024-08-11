namespace Nameless.RawgClient.Domains.Publishers.Requests {
    /// <summary>
    /// Represents a request object for publisher's details.
    /// </summary>
    /// <param name="Id">The publisher's identifier.</param>
    public sealed record GetPublisherDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetPublisherDetailsResponse, Publisher>;
}
