using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Tags.Responses {
    /// <summary>
    /// Represents the response for a tag's details.
    /// </summary>
    public sealed record GetTagDetailsResponse : Response<Tag>;
}
