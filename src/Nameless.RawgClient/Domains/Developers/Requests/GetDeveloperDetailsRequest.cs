using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Developers.Objects;
using Nameless.RawgClient.Domains.Developers.Responses;

namespace Nameless.RawgClient.Domains.Developers.Requests {
    /// <summary>
    /// Request for developer's details.
    /// </summary>
    /// <param name="Id">The developer's identifier.</param>
    public sealed record GetDeveloperDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetDeveloperDetailsResponse, Developer>;
}
