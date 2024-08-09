using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Tags.Responses {
    /// <summary>
    /// Represents the response for a list of tags.
    /// </summary>
    public sealed record GetTagsResponse : PaginableResponse<Tag>;
}
