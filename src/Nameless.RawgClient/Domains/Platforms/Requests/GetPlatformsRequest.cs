using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;
using Nameless.RawgClient.Domains.Platforms.Responses;

namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Request for a list of platforms.
    /// </summary>
    public sealed record GetPlatformsRequest
        : Request<GetPlatformsResponse, Platform>;
}
