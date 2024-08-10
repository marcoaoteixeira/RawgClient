using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Platforms.Responses {
    /// <summary>
    /// Represents the response for a list of parent platforms.
    /// </summary>
    public sealed record GetParentPlatformsResponse : PaginableResponse<ParentPlatform>;
}
