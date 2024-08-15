using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Tags.Objects;

namespace Nameless.RawgClient.Domains.Tags.Responses {
    /// <summary>
    /// Response for a list of tags.
    /// </summary>
    public sealed record GetTagsResponse
        : Response<Tag>;
}
