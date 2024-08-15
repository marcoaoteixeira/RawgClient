using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.CreatorRoles.Objects;

namespace Nameless.RawgClient.Domains.CreatorRoles.Responses {
    /// <summary>
    /// Response for a list of creator roles.
    /// </summary>
    public sealed record GetCreatorRolesResponse
        : Response<CreatorRole>;
}
