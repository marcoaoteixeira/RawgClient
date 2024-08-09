using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Developers.Responses {
    /// <summary>
    /// Represents the response for a developer's details.
    /// </summary>
    public sealed record GetDeveloperDetailsResponse : Response<Developer>;
}
