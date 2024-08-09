namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : IDeveloperHttpClient {
        public async Task<GetDevelopersResponse> GetDevelopersAsync(GetDevelopersRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<Developer>>(Endpoints.Developers.GetDevelopers,
                                                                    request,
                                                                    cancellationToken);

            return result.Match(
                success => success.CreateResponse<GetDevelopersResponse>(request),
                error => new GetDevelopersResponse { Error = error.Reason }
            );
        }

        public async Task<GetDeveloperDetailsResponse> GetDeveloperDetailsAsync(GetDeveloperDetailsRequest request, CancellationToken cancellationToken) {
            var endpoint = string.Format(CultureInfo.CurrentCulture, Endpoints.Developers.GetDeveloperDetails, request.Id);
            var result = await GetResultAsync<Developer>(endpoint,
                                                         request,
                                                         cancellationToken: cancellationToken);

            return result.Match(
                success => new GetDeveloperDetailsResponse { Results = [success] },
                error => new GetDeveloperDetailsResponse { Error = error.Reason }
            );
        }
    }
}
