using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Developers.Objects;

namespace Nameless.RawgClient.Domains.Developers.Responses {
    /// <summary>
    /// Response for developer's details.
    /// </summary>
    public sealed record GetDeveloperDetailsResponse : Response<Developer>;
}
