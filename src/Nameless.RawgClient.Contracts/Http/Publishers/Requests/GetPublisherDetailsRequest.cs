using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Http.Publishers.Requests {
    /// <summary>
    /// Represents a request object for publisher's details.
    /// </summary>
    /// <param name="Id">The publisher identifier.</param>
    public sealed record GetPublisherDetailsRequest([property: JsonProperty("id")] int Id) : Request;
}
