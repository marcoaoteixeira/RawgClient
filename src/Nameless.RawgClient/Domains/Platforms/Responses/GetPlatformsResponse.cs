using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;

namespace Nameless.RawgClient.Domains.Platforms.Responses {
    /// <summary>
    /// Response for a list of platforms.
    /// </summary>
    public sealed record GetPlatformsResponse
        : Response<Platform>;
}
