namespace Nameless.RawgClient.Http {
    public partial class RawgHttpClient : IGenreHttpClient {
        public async Task<GetGenresResponse> GetGenresAsync(GetGenresRequest request, CancellationToken cancellationToken) {
            var result = await GetResultAsync<Paginable<Genre>>(Endpoints.Genres.GetGenres,
                                                                request,
                                                                cancellationToken);
            
            return result.Match(
                success => success.CreateResponse<GetGenresResponse>(request),
                error => new GetGenresResponse { Error = error.Reason }
            );
        }

        public async Task<GetGenreDetailsResponse> GetGenreDetailsAsync(GetGenreDetailsRequest request, CancellationToken cancellationToken) {
            var endpoint = string.Format(CultureInfo.CurrentCulture, Endpoints.Genres.GetGenreDetails, request.Id);
            var result = await GetResultAsync<Genre>(endpoint, request, cancellationToken);

            return result.Match(
                success => new GetGenreDetailsResponse { Results = [success]},
                error => new GetGenreDetailsResponse { Error = error.Reason }
            );
        }
    }
}
