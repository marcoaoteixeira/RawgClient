using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Developers.Responses {
    /// <summary>
    /// Represents the response for a list of developers.
    /// </summary>
    public sealed record GetDevelopersResponse : PaginableResponse<Developer>;
}
