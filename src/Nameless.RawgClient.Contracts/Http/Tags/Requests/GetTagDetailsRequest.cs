using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Http.Tags.Requests {
    /// <summary>
    /// Represents a request object for tag's details.
    /// </summary>
    /// <param name="Id">The tag identifier.</param>
    public sealed record GetTagDetailsRequest([property: JsonProperty("id")] int Id) : Request;
}
