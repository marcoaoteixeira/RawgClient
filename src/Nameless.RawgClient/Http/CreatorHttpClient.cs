namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : ICreatorHttpClient {
        public async Task<GetCreatorsResponse> GetCreatorsAsync(GetCreatorsRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<Creator>>(Endpoints.Creators.GetCreators, request, cancellationToken);

            return CreateResponse<GetCreatorsRequest, GetCreatorsResponse, Creator>(request, result);
        }

        public async Task<GetCreatorDetailsResponse> GetCreatorDetailsAsync(GetCreatorDetailsRequest request, CancellationToken cancellationToken) {
            var endpoint = string.Format(CultureInfo.CurrentCulture, Endpoints.Creators.GetCreatorDetails, request.Id);
            var result = await GetResultAsync<Creator>(endpoint, request, cancellationToken);

            return CreateResponse<GetCreatorDetailsResponse, Creator>(result);
        }
    }
}
