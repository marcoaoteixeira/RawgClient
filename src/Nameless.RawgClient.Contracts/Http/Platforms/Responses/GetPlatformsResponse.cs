using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Platforms.Responses {
    /// <summary>
    /// Represents the response for a list of platforms.
    /// </summary>
    public sealed record GetPlatformsResponse : PaginableResponse<Platform>;
}
