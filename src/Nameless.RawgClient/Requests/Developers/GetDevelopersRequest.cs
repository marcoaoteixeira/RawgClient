using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Developers {
    /// <summary>
    /// Request for a list of developer.
    /// </summary>
    public sealed record GetDevelopersRequest
        : Request<Developer>;
}
