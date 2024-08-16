using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;

namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Request for a list of platforms.
    /// </summary>
    public sealed record GetPlatformsRequest
        : Request<Platform>;
}
