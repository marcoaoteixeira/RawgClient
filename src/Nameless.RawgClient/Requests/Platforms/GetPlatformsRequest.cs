using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Platforms {
    /// <summary>
    /// Request for a list of platforms.
    /// </summary>
    public sealed record GetPlatformsRequest
        : Request<Platform>;
}
