namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game object.
    /// </summary>
    public record Game : Entity {
        /// <summary>
        /// Gets or init field "name_original".
        /// </summary>
        [JsonPropertyName("name_original")]
        public string OriginalName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "metacritic_url".
        /// </summary>
        [JsonPropertyName("metacritic_url")]
        public string MetacriticUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "metacritic".
        /// </summary>
        [JsonPropertyName("metacritic")]
        public int MetacriticScore { get; init; }

        /// <summary>
        /// Gets or init field "metacritic_platforms".
        /// </summary>
        [JsonPropertyName("metacritic_platforms")]
        public MetacriticPlatformContainer[] MetacriticPlatforms { get; init; } = [];

        /// <summary>
        /// Gets or init field "released".
        /// </summary>
        [JsonPropertyName("released")]
        public DateTimeOffset ReleasedAt { get; init; }

        /// <summary>
        /// Gets or init field "tba".
        /// </summary>
        [JsonPropertyName("tba")]
        public bool Tba { get; init; }

        /// <summary>
        /// Gets or init field "updated".
        /// </summary>
        [JsonPropertyName("updated")]
        public DateTimeOffset UpdatedAt { get; init; }

        /// <summary>
        /// Gets or init field "background_image".
        /// </summary>
        [JsonPropertyName("background_image")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "background_image_additional".
        /// </summary>
        [JsonPropertyName("background_image_additional")]
        public string AdditionalBackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "website".
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "rating".
        /// </summary>
        [JsonPropertyName("rating")]
        public double Rating { get; init; }

        /// <summary>
        /// Gets or init field "rating_top".
        /// </summary>
        [JsonPropertyName("rating_top")]
        public int RatingTop { get; init; }

        /// <summary>
        /// Gets or init field "added".
        /// </summary>
        [JsonPropertyName("added")]
        public int Added { get; init; }

        /// <summary>
        /// Gets or init field "added_by_status".
        /// </summary>
        [JsonPropertyName("added_by_status")]
        public AddedByStatus? AddedByStatus { get; init; }

        /// <summary>
        /// Gets or init field "playtime".
        /// </summary>
        [JsonPropertyName("playtime")]
        public int Playtime { get; init; }

        /// <summary>
        /// Gets or init field "screenshots_count".
        /// </summary>
        [JsonPropertyName("screenshots_count")]
        public int ScreenshotsCount { get; init; }

        /// <summary>
        /// Gets or init field "movies_count".
        /// </summary>
        [JsonPropertyName("movies_count")]
        public int MoviesCount { get; init; }

        /// <summary>
        /// Gets or init field "creators_count".
        /// </summary>
        [JsonPropertyName("creators_count")]
        public int CreatorsCount { get; init; }

        /// <summary>
        /// Gets or init field "achievements_count".
        /// </summary>
        [JsonPropertyName("achievements_count")]
        public int AchievementsCount { get; init; }

        /// <summary>
        /// Gets or init field "parent_achievements_count".
        /// </summary>
        [JsonPropertyName("parent_achievements_count")]
        public int ParentAchievementsCount { get; init; }

        /// <summary>
        /// Gets or init field "reddit_url".
        /// </summary>
        [JsonPropertyName("reddit_url")]
        public string RedditUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_name".
        /// </summary>
        [JsonPropertyName("reddit_name")]
        public string RedditName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_description".
        /// </summary>
        [JsonPropertyName("reddit_description")]
        public string RedditDescription { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_logo".
        /// </summary>
        [JsonPropertyName("reddit_logo")]
        public string RedditLogo { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reddit_count".
        /// </summary>
        [JsonPropertyName("reddit_count")]
        public int RedditCount { get; init; }

        /// <summary>
        /// Gets or init field "twitch_count".
        /// </summary>
        [JsonPropertyName("twitch_count")]
        public int TwitchCount { get; init; }

        /// <summary>
        /// Gets or init field "youtube_count".
        /// </summary>
        [JsonPropertyName("youtube_count")]
        public int YoutubeCount { get; init; }

        /// <summary>
        /// Gets or init field "reviews_text_count".
        /// </summary>
        [JsonPropertyName("reviews_text_count")]
        public int ReviewsTextCount { get; init; }

        /// <summary>
        /// Gets or init field "ratings_count".
        /// </summary>
        [JsonPropertyName("ratings_count")]
        public int RatingsCount { get; init; }

        /// <summary>
        /// Gets or init field "suggestions_count".
        /// </summary>
        [JsonPropertyName("suggestions_count")]
        public int SuggestionsCount { get; init; }

        /// <summary>
        /// Gets or init field "alternative_names".
        /// </summary>
        [JsonPropertyName("alternative_names")]
        public string[] AlternativeNames { get; init; } = [];

        /// <summary>
        /// Gets or init field "parent_count".
        /// </summary>
        [JsonPropertyName("parents_count")]
        public int ParentsCount { get; init; }

        /// <summary>
        /// Gets or init field "additions_count".
        /// </summary>
        [JsonPropertyName("additions_count")]
        public int AdditionsCount { get; init; }

        /// <summary>
        /// Gets or init field "game_series_count".
        /// </summary>
        [JsonPropertyName("game_series_count")]
        public int GameSeriesCount { get; init; }

        /// <summary>
        /// Gets or init field "community_rating".
        /// </summary>
        [JsonPropertyName("community_rating")]
        public int CommunityRating { get; init; }

        /// <summary>
        /// Gets or init field "user_game".
        /// </summary>
        [JsonPropertyName("user_game")]
        public object? UserGame { get; init; }

        /// <summary>
        /// Gets or init field "reviews_count".
        /// </summary>
        [JsonPropertyName("reviews_count")]
        public int ReviewsCount { get; init; }

        /// <summary>
        /// Gets or init field "saturated_color".
        /// </summary>
        [JsonPropertyName("saturated_color")]
        public string SaturatedColor { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "dominant_color".
        /// </summary>
        [JsonPropertyName("dominant_color")]
        public string DominantColor { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "clip".
        /// </summary>
        [JsonPropertyName("clip")]
        public string Clip { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "description_raw".
        /// </summary>
        [JsonPropertyName("description_raw")]
        public string DescriptionRaw { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "ratings".
        /// </summary>
        [JsonPropertyName("ratings")]
        public Rating[] Ratings { get; init; } = [];

        /// <summary>
        /// Gets or init field "reactions".
        /// </summary>
        [JsonPropertyName("reactions")]
        public ReactionCollection Reactions { get; init; } = [];

        /// <summary>
        /// Gets or init field "parent_platforms".
        /// </summary>
        [JsonPropertyName("parent_platforms")]
        public ParentPlatformItem[] ParentPlatforms { get; set; } = [];

        /// <summary>
        /// Gets or init field "platforms".
        /// </summary>
        [JsonPropertyName("platforms")]
        public PlatformItem[] Platforms { get; set; } = [];

        /// <summary>
        /// Gets or init field "stores".
        /// </summary>
        [JsonPropertyName("stores")]
        public StoreItem[] Stores { get; set; } = [];

        /// <summary>
        /// Gets or init field "developers".
        /// </summary>
        [JsonPropertyName("developers")]
        public Developer[] Developers { get; set; } = [];

        /// <summary>
        /// Gets or init field "genres".
        /// </summary>
        [JsonPropertyName("genres")]
        public Genre[] Genres { get; set; } = [];

        /// <summary>
        /// Gets or init field "tags".
        /// </summary>
        [JsonPropertyName("tags")]
        public Tag[] Tags { get; set; } = [];

        /// <summary>
        /// Gets or init field "publishers".
        /// </summary>
        [JsonPropertyName("publishers")]
        public Publisher[] Publisher { get; set; } = [];

        /// <summary>
        /// Gets or init field "esrb_rating".
        /// </summary>
        [JsonPropertyName("esrb_rating")]
        public EsrbRating? EsrbRating { get; set; }

        /// <summary>
        /// Gets or init field "short_screenshots".
        /// </summary>
        [JsonPropertyName("short_screenshots")]
        public Screenshot[] ShortScreenshots { get; set; } = [];
    }
}
