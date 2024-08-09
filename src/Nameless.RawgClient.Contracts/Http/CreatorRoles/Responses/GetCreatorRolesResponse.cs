using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Http.CreatorRoles.Requests;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.CreatorRoles.Responses {
    /// <summary>
    /// Get creator's roles response object.
    /// </summary>
    public sealed record GetCreatorRolesResponse : PaginableResponse<GetCreatorRolesRequest, CreatorRole> {
    }
}
