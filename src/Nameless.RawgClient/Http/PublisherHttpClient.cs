namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : IPublisherHttpClient {
        public async Task<GetPublishersResponse> GetPublishersAsync(GetPublishersRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<Publisher>>(Endpoints.Publishers.GetPublishers,
                                                                    request,
                                                                    cancellationToken);

            return result.Match(
                success => success.CreateResponse<GetPublishersRequest, GetPublishersResponse>(request),
                error => new GetPublishersResponse { Error = error.Reason }
            );
        }

        public async Task<GetPublisherDetailsResponse> GetPublisherDetailsAsync(GetPublisherDetailsRequest request, CancellationToken cancellationToken) {
            var endpoint = string.Format(CultureInfo.CurrentCulture, Endpoints.Publishers.GetPublisherDetails, request.Id);
            var result = await GetResultAsync<Publisher>(endpoint, request, cancellationToken);

            return result.Match(
                success => new GetPublisherDetailsResponse { Result = success },
                error => new GetPublisherDetailsResponse { Error = error.Reason }
            );
        }
    }
}
