using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.CreatorRoles.Objects;

namespace Nameless.RawgClient.Domains.CreatorRoles.Requests {
    /// <summary>
    /// Request for a list of creator roles.
    /// </summary>
    public sealed record GetCreatorRolesRequest
        : Request<CreatorRole>;
}
