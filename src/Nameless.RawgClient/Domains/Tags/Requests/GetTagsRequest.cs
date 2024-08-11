namespace Nameless.RawgClient.Domains.Tags.Requests {
    /// <summary>
    /// Represents a request object for a list of tag.
    /// </summary>
    public sealed record GetTagsRequest
        : Request<GetTagsResponse, Tag>;
}
