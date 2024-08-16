using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator object.
    /// </summary>
    public record Creator : Entity {
        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonPropertyName("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "image_background".
        /// </summary>
        [JsonPropertyName("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games_count".
        /// </summary>
        [JsonPropertyName("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reviews_count".
        /// </summary>
        [JsonPropertyName("reviews_count")]
        public int ReviewsCount { get; init; }

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
        /// Gets or init field "updated".
        /// </summary>
        [JsonPropertyName("updated")]
        public DateTimeOffset UpdateAt { get; init; }

        /// <summary>
        /// Gets or init field "positions".
        /// </summary>
        [JsonPropertyName("positions")]
        public Position[] Positions { get; init; } = [];

        /// <summary>
        /// Gets or init field "games".
        /// </summary>
        [JsonPropertyName("games")]
        public Game[] Games { get; init; } = [];

        /// <summary>
        /// Gets or init field "timeline".
        /// </summary>
        [JsonPropertyName("timeline")]
        public Timeline[] Timeline { get; set; } = [];

        /// <summary>
        /// Gets or init field "platforms".
        /// </summary>
        [JsonPropertyName("platforms")]
        public PlatformGroup? Platforms { get; set; }

        /// <summary>
        /// Gets or init field "ratings".
        /// </summary>
        [JsonPropertyName("ratings")]
        public Rating[] Ratings { get; set; } = [];
    }
}
