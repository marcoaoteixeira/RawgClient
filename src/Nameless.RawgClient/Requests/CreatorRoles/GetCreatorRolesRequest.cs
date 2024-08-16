using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.CreatorRoles {
    /// <summary>
    /// Request for a list of creator roles.
    /// </summary>
    public sealed record GetCreatorRolesRequest
        : Request<CreatorRole>;
}
