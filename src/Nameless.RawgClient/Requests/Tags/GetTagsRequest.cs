using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Tags {
    /// <summary>
    /// Request for a list of tags.
    /// </summary>
    public sealed record GetTagsRequest
        : Request<Tag>;
}
