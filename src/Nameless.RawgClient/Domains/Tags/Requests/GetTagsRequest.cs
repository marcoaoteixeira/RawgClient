using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Tags.Objects;
using Nameless.RawgClient.Domains.Tags.Responses;

namespace Nameless.RawgClient.Domains.Tags.Requests {
    /// <summary>
    /// Request for a list of tags.
    /// </summary>
    public sealed record GetTagsRequest
        : Request<GetTagsResponse, Tag>;
}
