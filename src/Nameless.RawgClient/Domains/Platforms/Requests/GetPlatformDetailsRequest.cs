using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Platforms.Objects;
using Nameless.RawgClient.Domains.Platforms.Responses;

namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Request for platform's details.
    /// </summary>
    /// <param name="Id">The platform's identifier.</param>
    public sealed record GetPlatformDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetPlatformDetailsResponse, Platform>;
}
