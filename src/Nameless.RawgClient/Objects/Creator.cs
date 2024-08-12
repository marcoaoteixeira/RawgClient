namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Creator object.
    /// </summary>
    public record Creator {
        /// <summary>
        /// Gets or init the creator's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init the creator's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the creator's image.
        /// </summary>
        [JsonProperty("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets a background image URL.
        /// </summary>
        [JsonProperty("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the creator's games count.
        /// </summary>
        [JsonProperty("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init the creator's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the creator's reviews count.
        /// </summary>
        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; init; }

        /// <summary>
        /// Gets or init the creator's rating.
        /// </summary>
        [JsonProperty("rating")]
        public decimal Rating { get; init; }

        /// <summary>
        /// Gets or init the creator's rating TOP.
        /// </summary>
        [JsonProperty("rating_top")]
        public int RatingTop { get; init; }

        /// <summary>
        /// Gets or init the creator's last update.
        /// </summary>
        [JsonProperty("updated")]
        public DateTimeOffset UpdatedAt { get; init; }

        /// <summary>
        /// Gets or init the creator's works platform.
        /// </summary>
        [JsonProperty("platforms")]
        public CreatorPlatformRoot Platforms { get; init; } = new();

        /// <summary>
        /// Gets or init the creator's positions.
        /// </summary>
        [JsonProperty("positions")]
        public Position[] Positions { get; init; } = [];

        /// <summary>
        /// Gets or init the creator's games.
        /// </summary>
        [JsonProperty("games")]
        public Game[] Games { get; init; } = [];

        /// <summary>
        /// Gets or init the timeline.
        /// </summary>
        [JsonProperty("timeline")]
        public Timeline[] Timeline { get; set; } = [];
    }
}
