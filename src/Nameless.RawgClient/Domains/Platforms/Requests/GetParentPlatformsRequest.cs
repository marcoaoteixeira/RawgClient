using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;
using Nameless.RawgClient.Domains.Platforms.Responses;

namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Request for a list of parent platforms.
    /// </summary>
    public sealed record GetParentPlatformsRequest
        : Request<GetParentPlatformsResponse, ParentPlatform>;
}
