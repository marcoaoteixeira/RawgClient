namespace Nameless.RawgClient.Domains.Publishers.Requests {
    /// <summary>
    /// Represents a request object for a list of publisher.
    /// </summary>
    public sealed record GetPublishersRequest
        : Request<GetPublishersResponse, Publisher>;
}
