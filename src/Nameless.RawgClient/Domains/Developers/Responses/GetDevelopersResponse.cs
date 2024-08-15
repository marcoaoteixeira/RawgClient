using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Developers.Objects;

namespace Nameless.RawgClient.Domains.Developers.Responses {
    /// <summary>
    /// Response for a list of developers.
    /// </summary>
    public sealed record GetDevelopersResponse : Response<Developer>;
}
