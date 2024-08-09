using Nameless.RawgClient.Contracts.Http.CreatorRoles.Requests;
using Nameless.RawgClient.Contracts.Http.CreatorRoles.Responses;

namespace Nameless.RawgClient.Contracts.Http.CreatorRoles {
    /// <summary>
    /// Provides means to query creator roles endpoint.
    /// </summary>
    public interface ICreatorRoleHttpClient {
        /// <summary>
        /// Retrieves a list of creator positions (jobs).
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// A <see cref="GetCreatorRolesResponse"/> containing all information about creator positions.
        /// </returns>
        Task<GetCreatorRolesResponse> GetCreatorRolesAsync(GetCreatorRolesRequest request, CancellationToken cancellationToken);
    }
}
