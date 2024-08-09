namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : ICreatorRoleHttpClient {
        public async Task<GetCreatorRolesResponse> GetCreatorRolesAsync(GetCreatorRolesRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<CreatorRole>>(Endpoints.CreatorRoles.GetCreatorRoles,
                                                                      request,
                                                                      cancellationToken);

            return result.Match(
                success => success.CreateResponse<GetCreatorRolesRequest, GetCreatorRolesResponse>(request),
                error => new GetCreatorRolesResponse { Error = error.Reason }
            );
        }
    }
}
