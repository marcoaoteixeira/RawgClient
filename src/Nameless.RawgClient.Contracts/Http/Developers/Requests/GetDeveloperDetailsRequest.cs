using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Http.Developers.Requests {
    /// <summary>
    /// Represents a request object for developer's details.
    /// </summary>
    /// <param name="Id">The developer identifier.</param>
    public sealed record GetDeveloperDetailsRequest([property: JsonProperty("id")] int Id) : Request;
}
