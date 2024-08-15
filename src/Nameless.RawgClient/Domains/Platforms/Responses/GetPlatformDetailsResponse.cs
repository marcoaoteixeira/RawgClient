using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;

namespace Nameless.RawgClient.Domains.Platforms.Responses {
    /// <summary>
    /// Response for platform's details.
    /// </summary>
    public sealed record GetPlatformDetailsResponse
        : Response<Platform>;
}
