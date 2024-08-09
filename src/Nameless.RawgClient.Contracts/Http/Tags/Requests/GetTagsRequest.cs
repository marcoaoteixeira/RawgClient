using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Tags.Requests {
    /// <summary>
    /// Represents a request object for a list of tag.
    /// </summary>
    public sealed record GetTagsRequest : PaginableRequest;
}
