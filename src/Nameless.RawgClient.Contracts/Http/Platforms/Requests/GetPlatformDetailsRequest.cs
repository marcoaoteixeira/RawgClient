using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Http.Platforms.Requests {
    /// <summary>
    /// Represents a request object for platform's details.
    /// </summary>
    /// <param name="Id">The platform identifier.</param>
    public sealed record GetPlatformDetailsRequest([property: JsonProperty("id")] int Id) : Request;
}
