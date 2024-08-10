using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Platforms.Responses {
    /// <summary>
    /// Represents the response for a platform's details.
    /// </summary>
    public sealed record GetPlatformDetailsResponse : Response<Platform>;
}
