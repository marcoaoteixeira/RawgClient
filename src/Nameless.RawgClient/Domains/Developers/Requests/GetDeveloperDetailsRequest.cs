using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Developers.Objects;

namespace Nameless.RawgClient.Domains.Developers.Requests {
    /// <summary>
    /// Request for developer's details.
    /// </summary>
    /// <param name="Id">The developer's identifier.</param>
    public sealed record GetDeveloperDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Developer>;
}
