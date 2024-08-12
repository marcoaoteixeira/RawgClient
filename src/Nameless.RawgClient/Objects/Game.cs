namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game object.
    /// </summary>
    public record Game {
        /// <summary>
        /// Gets the game's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the game's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        [JsonProperty("name_original")]
        public string OriginalName { get; init; } = string.Empty;

        /// <summary>
        /// Gets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        [JsonProperty("metacritic_url")]
        public string MetacriticUrl { get; init; } = string.Empty;

        [JsonProperty("metacritic")]
        public int MetacriticScore { get; init; }

        [JsonProperty("metacritic_platforms")]
        public MetacriticPlatform[] MetacriticPlatforms { get; init; } = [];

        [JsonProperty("released")]
        public DateTimeOffset ReleasedAt { get; init; }

        [JsonProperty("tba")]
        public bool Tba { get; init; }

        [JsonProperty("updated")]
        public DateTimeOffset UpdatedAt { get; init; }

        [JsonProperty("background_image")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        [JsonProperty("background_image_additional")]
        public string AdditionalBackgroundImageUrl { get; init; } = string.Empty;

        [JsonProperty("website")]
        public string Website { get; init; } = string.Empty;

        [JsonProperty("rating")]
        public double Rating { get; init; }

        [JsonProperty("rating_top")]
        public int RatingTop { get; init; }

        [JsonProperty("ratings")]
        public Rating[] Ratings { get; init; } = [];

        [JsonProperty("reactions")]
        public Dictionary<string, int> Reactions { get; init; } = [];

        /// <summary>
        /// Gets the added param.
        /// </summary>
        [JsonProperty("added")]
        public int Added { get; init; }

        [JsonProperty("added_by_status")]
        public AddedByStatus? AddedByStatus { get; init; }

         [JsonProperty("playtime")]
        public int Playtime { get; init; }

        [JsonProperty("screenshots_count")]
        public int ScreenshotsCount { get; init; }

        [JsonProperty("movies_count")]
        public int MoviesCount { get; init; }

        [JsonProperty("creators_count")]
        public int CreatorsCount { get; init; }

        [JsonProperty("achievements_count")]
        public int AchievementsCount { get; init; }

        [JsonProperty("parent_achievements_count")]
        public int ParentAchievementsCount { get; init; }

        [JsonProperty("reddit_url")]
        public string RedditUrl { get; init; } = string.Empty;

        [JsonProperty("reddit_name")]
        public string RedditName { get; init; } = string.Empty;

        [JsonProperty("reddit_description")]
        public string RedditDescription { get; init; } = string.Empty;

        [JsonProperty("reddit_logo")]
        public string RedditLogo { get; init; } = string.Empty;

        [JsonProperty("reddit_count")]
        public int RedditCount { get; init; }

        [JsonProperty("twitch_count")]
        public int TwitchCount { get; init; }

        [JsonProperty("youtube_count")]
        public int YoutubeCount { get; init; }

        [JsonProperty("reviews_text_count")]
        public int ReviewsTextCount { get; init; }

        [JsonProperty("ratings_count")]
        public int RatingsCount { get; init; }

        [JsonProperty("suggestions_count")]
        public int SuggestionsCount { get; init; }

        [JsonProperty("alternative_names")]
        public string[] AlternativeNames { get; init; } = [];

        [JsonProperty("parents_count")]
        public int ParentsCount { get; init; }

        [JsonProperty("additions_count")]
        public int AdditionsCount { get; init; }

        [JsonProperty("game_series_count")]
        public int GameSeriesCount { get; init; }

        [JsonProperty("user_game")]
        public object? UserGame { get; init; }

        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; init; }

        [JsonProperty("saturated_color")]
        public string SaturatedColor { get; init; } = string.Empty;

        [JsonProperty("dominant_color")]
        public string DominantColor { get; init; } = string.Empty;

        [JsonProperty("parent_platforms")]
        public GameParentPlatform[] ParentPlatforms { get; init; } = [];


    }
}
