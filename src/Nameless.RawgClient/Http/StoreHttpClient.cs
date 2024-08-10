using Nameless.RawgClient.Contracts.Http.Stores;
using Nameless.RawgClient.Contracts.Http.Stores.Requests;
using Nameless.RawgClient.Contracts.Http.Stores.Responses;

namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : IStoreHttpClient {
        public async Task<GetStoresResponse> GetStoresAsync(GetStoresRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<Store>>(Endpoints.Stores.GetStores,
                                                                request,
                                                                cancellationToken);

            return result.Match(
                success => success.CreateResponse<GetStoresResponse>(request),
                error => new GetStoresResponse { Error = error.Reason }
            );
        }

        public async Task<GetStoreDetailsResponse> GetStoreDetailsAsync(GetStoreDetailsRequest request, CancellationToken cancellationToken) {
            var endpoint = string.Format(CultureInfo.CurrentCulture, Endpoints.Stores.GetStoreDetails, request.Id);
            var result = await GetResultAsync<Store>(endpoint, request, cancellationToken);

            return result.Match(
                success => new GetStoreDetailsResponse { Results = [success] },
                error => new GetStoreDetailsResponse { Error = error.Reason }
            );
        }
    }
}
