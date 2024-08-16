using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Games {
    /// <summary>
    /// Request for a list of games.
    /// </summary>
    public record GetGamesRequest
        : Request<Game> {
        private const string SearchKey = "search";
        private const string SearchPreciseKey = "search_precise";
        private const string SearchExactKey = "search_exact";
        private const string ParentPlatformsKey = "parent_platforms";
        private const string PlatformsKey = "platforms";
        private const string StoresKey = "stores";
        private const string DevelopersKey = "developers";
        private const string PublishersKey = "publishers";
        private const string GenresKey = "genres";
        private const string TagsKey = "tags";
        private const string CreatorsKey = "creators";
        private const string DatesKey = "dates";
        private const string UpdatedKey = "updated";
        private const string PlatformsCountKey = "platforms_count";
        private const string MetacriticKey = "metacritic";
        private const string ExcludeCollectionKey = "exclude_collection";
        private const string ExcludeAdditionsKey = "exclude_additions";
        private const string ExcludeParentsKey = "exclude_parents";
        private const string ExcludeGameSeriesKey = "exclude_game_series";
        private const string ExcludeStoresKey = "exclude_stores";

        /// <summary>
        /// Gets or init field "search". Search query.
        /// </summary>
        [JsonPropertyName(SearchKey)]
        public string? Search { get; init; }

        /// <summary>
        /// Gets or init field "search_precise". Disable fuzziness for the search query.
        /// </summary>
        [JsonPropertyName(SearchPreciseKey)]
        public bool? SearchPrecise { get; init; }

        /// <summary>
        /// Gets or init field "search_exact". Mark the search query as exact.
        /// </summary>
        [JsonPropertyName(SearchExactKey)]
        public bool? SearchExact { get; init; }

        /// <summary>
        /// Gets or init field "parent_platforms". Filter by parent platforms, for example: 1,2,3.
        /// </summary>
        [JsonPropertyName(ParentPlatformsKey)]
        public object[] ParentPlatforms { get; init; } = [];

        /// <summary>
        /// Gets or init field "platforms". Filter by platforms, for example: 4,5.
        /// </summary>
        [JsonPropertyName(PlatformsKey)]
        public object[] Platforms { get; init; } = [];

        /// <summary>
        /// Gets or init field "stores". Filter by stores, for example: 5,6.
        /// </summary>
        [JsonPropertyName(StoresKey)]
        public object[] Stores { get; init; } = [];

        /// <summary>
        /// Gets or init field "developers". Filter by developers, for example: 1612,18893 or valve-software,feral-interactive.
        /// </summary>
        [JsonPropertyName(DevelopersKey)]
        public object[] Developers { get; init; } = [];

        /// <summary>
        /// Gets or init field "publishers". Filter by publishers, for example: 354,20987 or electronic-arts,microsoft-studios.
        /// </summary>
        [JsonPropertyName(PublishersKey)]
        public object[] Publishers { get; init; } = [];

        /// <summary>
        /// Gets or init field "genres". Filter by genres, for example: 4,51 or action,indie.
        /// </summary>
        [JsonPropertyName(GenresKey)]
        public object[] Genres { get; init; } = [];

        /// <summary>
        /// Gets or init field "tags". Filter by tags, for example: 31,7 or singleplayer,multiplayer.
        /// </summary>
        [JsonPropertyName(TagsKey)]
        public object[] Tags { get; init; } = [];

        /// <summary>
        /// Gets or init field "creators". Filter by creators, for example: 78,28 or cris-velasco,mike-morasky.
        /// </summary>
        [JsonPropertyName(CreatorsKey)]
        public object[] Creators { get; init; } = [];

        /// <summary>
        /// Gets or init field "dates". Filter by a release date, for example: 2010-01-01,2018-12-31,1960-01-01,1969-12-31.
        /// </summary>
        [JsonPropertyName(DatesKey)]
        public DateOnly[] Dates { get; init; } = [];

        /// <summary>
        /// Gets or init field "update". Filter by an update date, for example: 2020-12-01,2020-12-31.
        /// </summary>
        [JsonPropertyName(UpdatedKey)]
        public DateOnly[] Updated { get; init; } = [];

        /// <summary>
        /// Gets or init field "platforms_count". Filter by platforms count, for example: 1.
        /// </summary>
        [JsonPropertyName(PlatformsCountKey)]
        public int? PlatformsCount { get; init; }

        /// <summary>
        /// Gets or init field "metacritic". Filter by a metacritic rating, for example: 80,100.
        /// </summary>
        [JsonPropertyName(MetacriticKey)]
        public int? Metacritic { get; init; }

        /// <summary>
        /// Gets or init field "exclude_collection". Exclude games from a particular collection, for example: 123.
        /// </summary>
        [JsonPropertyName(ExcludeCollectionKey)]
        public int? ExcludeCollection { get; init; }

        /// <summary>
        /// Gets or init field "exclude_additions". Exclude additions.
        /// </summary>
        [JsonPropertyName(ExcludeAdditionsKey)]
        public bool? ExcludeAdditions { get; init; }

        /// <summary>
        /// Gets or init field "exclude_parents". Exclude games which have additions.
        /// </summary>
        [JsonPropertyName(ExcludeParentsKey)]
        public bool? ExcludeParents { get; init; }

        /// <summary>
        /// Gets or init field "exclude_game_series". Exclude games which included in a game series.
        /// </summary>
        [JsonPropertyName(ExcludeGameSeriesKey)]
        public bool? ExcludeGameSeries { get; init; }

        /// <summary>
        /// Gets or init field "exclude_stores". Exclude stores, for example: 5,6.
        /// </summary>
        [JsonPropertyName(ExcludeStoresKey)]
        public object[] ExcludeStores { get; init; } = [];

        /// <inheritdoc />
        public override Dictionary<string, object[]> GetQueryParams() {
            // Get the base record parameters
            var result = base.GetQueryParams();

            if (!string.IsNullOrWhiteSpace(Search)) {
                result[SearchKey] = [Search];
            }

            if (SearchPrecise.HasValue) {
                result[SearchPreciseKey] = [SearchPrecise.Value];
            }

            if (SearchExact.HasValue) {
                result[SearchExactKey] = [SearchExact.Value];
            }

            if (ParentPlatforms.Length > 0) {
                result[ParentPlatformsKey] = ParentPlatforms;
            }

            if (Platforms.Length > 0) {
                result[PlatformsKey] = Platforms;
            }

            if (Stores.Length > 0) {
                result[StoresKey] = Stores;
            }

            if (Developers.Length > 0) {
                result[DevelopersKey] = Developers;
            }

            if (Publishers.Length > 0) {
                result[PublishersKey] = Publishers;
            }

            if (Genres.Length > 0) {
                result[GenresKey] = Genres;
            }

            if (Tags.Length > 0) {
                result[TagsKey] = Tags;
            }

            if (Creators.Length > 0) {
                result[CreatorsKey] = Creators;
            }

            if (Dates.Length > 0) {
                result[DatesKey] = Dates.Select(date => $"{date:yyyy-MM-dd}")
                                        .ToArray<object>();
            }

            if (Updated.Length > 0) {
                result[UpdatedKey] = Updated.Select(date => $"{date:yyyy-MM-dd}")
                                            .ToArray<object>();
            }

            if (PlatformsCount.HasValue) {
                result[PlatformsCountKey] = [PlatformsCount.Value];
            }

            if (Metacritic.HasValue) {
                result[MetacriticKey] = [Metacritic.Value];
            }

            if (ExcludeCollection.HasValue) {
                result[ExcludeCollectionKey] = [ExcludeCollection.Value];
            }

            if (ExcludeAdditions.HasValue) {
                result[ExcludeAdditionsKey] = [ExcludeAdditions.Value];
            }

            if (ExcludeParents.HasValue) {
                result[ExcludeParentsKey] = [ExcludeParents.Value];
            }

            if (ExcludeGameSeries.HasValue) {
                result[ExcludeGameSeriesKey] = [ExcludeGameSeries.Value];
            }

            if (ExcludeStores.Length > 0) {
                result[ExcludeStoresKey] = ExcludeStores;
            }

            return result;
        }
    }
}
