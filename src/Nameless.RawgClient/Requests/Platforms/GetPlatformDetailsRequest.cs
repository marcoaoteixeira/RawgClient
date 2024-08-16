using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Platforms {
    /// <summary>
    /// Request for platform's details.
    /// </summary>
    /// <param name="Id">The platform's identifier.</param>
    public sealed record GetPlatformDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Platform>;
}
