using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Tags.Objects;

namespace Nameless.RawgClient.Domains.Tags.Responses {
    /// <summary>
    /// Response for tag's details.
    /// </summary>
    public sealed record GetTagDetailsResponse
        : Response<Tag>;
}
