using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Developers {
    /// <summary>
    /// Request for developer's details.
    /// </summary>
    /// <param name="Id">The developer's identifier.</param>
    public sealed record GetDeveloperDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Developer>;
}
