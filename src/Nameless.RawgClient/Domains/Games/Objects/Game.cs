using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game object.
    /// </summary>
    public record Game : Entity {
        /// <summary>
        /// Gets or init field "name_original".
        /// </summary>
        [JsonProperty("name_original")]
        public string OriginalName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "metacritic_url".
        /// </summary>
        [JsonProperty("metacritic_url")]
        public string MetacriticUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "metacritic".
        /// </summary>
        [JsonProperty("metacritic")]
        public int MetacriticScore { get; init; }

        /// <summary>
        /// Gets or init field "metacritic_platforms".
        /// </summary>
        [JsonProperty("metacritic_platforms")]
        public MetacriticPlatform[] MetacriticPlatforms { get; init; } = [];

        /// <summary>
        /// Gets or init field "released".
        /// </summary>
        [JsonProperty("released")]
        public DateTimeOffset ReleasedAt { get; init; }

        /// <summary>
        /// Gets or init field "tba".
        /// </summary>
        [JsonProperty("tba")]
        public bool Tba { get; init; }

        /// <summary>
        /// Gets or init field "updated".
        /// </summary>
        [JsonProperty("updated")]
        public DateTimeOffset UpdatedAt { get; init; }

        /// <summary>
        /// Gets or init field "background_image".
        /// </summary>
        [JsonProperty("background_image")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "background_image_additional".
        /// </summary>
        [JsonProperty("background_image_additional")]
        public string AdditionalBackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "website".
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "rating".
        /// </summary>
        [JsonProperty("rating")]
        public double Rating { get; init; }

        /// <summary>
        /// Gets or init field "rating_top".
        /// </summary>
        [JsonProperty("rating_top")]
        public int RatingTop { get; init; }

        /// <summary>
        /// Gets or init field "added".
        /// </summary>
        [JsonProperty("added")]
        public int Added { get; init; }

        /// <summary>
        /// Gets or init field "added_by_status".
        /// </summary>
        [JsonProperty("added_by_status")]
        public AddedByStatus? AddedByStatus { get; init; }

        /// <summary>
        /// Gets or init field "playtime".
        /// </summary>
        [JsonProperty("playtime")]
        public int Playtime { get; init; }

        /// <summary>
        /// Gets or init field "screenshots_count".
        /// </summary>
        [JsonProperty("screenshots_count")]
        public int ScreenshotsCount { get; init; }

        /// <summary>
        /// Gets or init field "movies_count".
        /// </summary>
        [JsonProperty("movies_count")]
        public int MoviesCount { get; init; }

        /// <summary>
        /// Gets or init field "creators_count".
        /// </summary>
        [JsonProperty("creators_count")]
        public int CreatorsCount { get; init; }

        /// <summary>
        /// Gets or init field "achievements_count".
        /// </summary>
        [JsonProperty("achievements_count")]
        public int AchievementsCount { get; init; }

        /// <summary>
        /// Gets or init field "parent_achievements_count".
        /// </summary>
        [JsonProperty("parent_achievements_count")]
        public int ParentAchievementsCount { get; init; }

        /// <summary>
        /// Gets or init field "reddit_url".
        /// </summary>
        [JsonProperty("reddit_url")]
        public string RedditUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_name".
        /// </summary>
        [JsonProperty("reddit_name")]
        public string RedditName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_description".
        /// </summary>
        [JsonProperty("reddit_description")]
        public string RedditDescription { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_logo".
        /// </summary>
        [JsonProperty("reddit_logo")]
        public string RedditLogo { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_count".
        /// </summary>
        [JsonProperty("reddit_count")]
        public int RedditCount { get; init; }

        /// <summary>
        /// Gets or init field "twitch_count".
        /// </summary>
        [JsonProperty("twitch_count")]
        public int TwitchCount { get; init; }

        /// <summary>
        /// Gets or init field "youtube_count".
        /// </summary>
        [JsonProperty("youtube_count")]
        public int YoutubeCount { get; init; }

        /// <summary>
        /// Gets or init field "reviews_text_count".
        /// </summary>
        [JsonProperty("reviews_text_count")]
        public int ReviewsTextCount { get; init; }

        /// <summary>
        /// Gets or init field "ratings_count".
        /// </summary>
        [JsonProperty("ratings_count")]
        public int RatingsCount { get; init; }

        /// <summary>
        /// Gets or init field "suggestions_count".
        /// </summary>
        [JsonProperty("suggestions_count")]
        public int SuggestionsCount { get; init; }

        /// <summary>
        /// Gets or init field "alternative_names".
        /// </summary>
        [JsonProperty("alternative_names")]
        public string[] AlternativeNames { get; init; } = [];

        /// <summary>
        /// Gets or init field "parent_count".
        /// </summary>
        [JsonProperty("parents_count")]
        public int ParentsCount { get; init; }

        /// <summary>
        /// Gets or init field "additions_count".
        /// </summary>
        [JsonProperty("additions_count")]
        public int AdditionsCount { get; init; }

        /// <summary>
        /// Gets or init field "game_series_count".
        /// </summary>
        [JsonProperty("game_series_count")]
        public int GameSeriesCount { get; init; }

        /// <summary>
        /// Gets or init field "community_rating".
        /// </summary>
        [JsonProperty("community_rating")]
        public int CommunityRating { get; init; }

        /// <summary>
        /// Gets or init field "user_game".
        /// </summary>
        [JsonProperty("user_game")]
        public object? UserGame { get; init; }

        /// <summary>
        /// Gets or init field "reviews_count".
        /// </summary>
        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; init; }

        /// <summary>
        /// Gets or init field "saturated_color".
        /// </summary>
        [JsonProperty("saturated_color")]
        public string SaturatedColor { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "dominant_color".
        /// </summary>
        [JsonProperty("dominant_color")]
        public string DominantColor { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "clip".
        /// </summary>
        [JsonProperty("clip")]
        public string Clip { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "description_raw".
        /// </summary>
        [JsonProperty("description_raw")]
        public string DescriptionRaw { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "ratings".
        /// </summary>
        [JsonProperty("ratings")]
        public Rating[] Ratings { get; init; } = [];

        /// <summary>
        /// Gets or init field "reactions".
        /// </summary>
        [JsonProperty("reactions")]
        public Dictionary<string, int> Reactions { get; init; } = [];

        /// <summary>
        /// Gets or init field "parent_platforms".
        /// </summary>
        [JsonProperty("parent_platforms")]
        public ParentPlatformItem[] ParentPlatforms { get; set; } = [];

        /// <summary>
        /// Gets or init field "platforms".
        /// </summary>
        [JsonProperty("platforms")]
        public PlatformItem[] Platforms { get; set; } = [];

        /// <summary>
        /// Gets or init field "stores".
        /// </summary>
        [JsonProperty("stores")]
        public StoreItem[] Stores { get; set; } = [];

        /// <summary>
        /// Gets or init field "developers".
        /// </summary>
        [JsonProperty("developers")]
        public Developer[] Developers { get; set; } = [];

        /// <summary>
        /// Gets or init field "genres".
        /// </summary>
        [JsonProperty("genres")]
        public Genre[] Genres { get; set; } = [];

        /// <summary>
        /// Gets or init field "tags".
        /// </summary>
        [JsonProperty("tags")]
        public Tag[] Tags { get; set; } = [];

        /// <summary>
        /// Gets or init field "publishers".
        /// </summary>
        [JsonProperty("publishers")]
        public Publisher[] Publisher { get; set; } = [];

        /// <summary>
        /// Gets or init field "esrb_rating".
        /// </summary>
        [JsonProperty("esrb_rating")]
        public EsrbRating? EsrbRating { get; set; }

        /// <summary>
        /// Gets or init field "short_screenshots".
        /// </summary>
        [JsonProperty("short_screenshots")]
        public ShortScreenshot[] ShortScreenshots { get; set; } = [];
    }
}
