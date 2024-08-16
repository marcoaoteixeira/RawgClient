using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Platforms {
    /// <summary>
    /// Request for a list of parent platforms.
    /// </summary>
    public sealed record GetParentPlatformsRequest
        : Request<ParentPlatform>;
}
