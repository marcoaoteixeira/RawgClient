using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Tags.Objects;

namespace Nameless.RawgClient.Domains.Tags.Requests {
    /// <summary>
    /// Request for a list of tags.
    /// </summary>
    public sealed record GetTagsRequest
        : Request<Tag>;
}
