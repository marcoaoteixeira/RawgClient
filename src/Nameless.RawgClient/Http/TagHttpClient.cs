namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : ITagHttpClient {
        public async Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<Tag>>(Endpoints.Tags.GetTags,
                                                              request,
                                                              cancellationToken);

            return result.Match(
                success => success.CreateResponse<GetTagsRequest, GetTagsResponse>(request),
                error => new GetTagsResponse { Error = error.Reason }
            );
        }

        public async Task<GetTagDetailsResponse> GetTagDetailsAsync(GetTagDetailsRequest request, CancellationToken cancellationToken) {
            var endpoint = string.Format(CultureInfo.CurrentCulture, Endpoints.Tags.GetTagDetails, request.Id);
            var result = await GetResultAsync<Tag>(endpoint, request, cancellationToken);

            return result.Match(
                success => new GetTagDetailsResponse { Result = success },
                error => new GetTagDetailsResponse { Error = error.Reason }
            );
        }
    }
}
