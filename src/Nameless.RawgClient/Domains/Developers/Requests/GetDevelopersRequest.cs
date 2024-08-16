using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Developers.Objects;

namespace Nameless.RawgClient.Domains.Developers.Requests {
    /// <summary>
    /// Request for a list of developer.
    /// </summary>
    public sealed record GetDevelopersRequest
        : Request<Developer>;
}
