using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;

namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Request for a list of parent platforms.
    /// </summary>
    public sealed record GetParentPlatformsRequest
        : Request<ParentPlatform>;
}
