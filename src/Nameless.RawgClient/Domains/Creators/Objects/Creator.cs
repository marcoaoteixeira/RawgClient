using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator object.
    /// </summary>
    public record Creator : Entity {
        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonProperty("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "image_background".
        /// </summary>
        [JsonProperty("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games_count".
        /// </summary>
        [JsonProperty("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "reviews_count".
        /// </summary>
        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; init; }

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
        /// Gets or init field "updated".
        /// </summary>
        [JsonProperty("updated")]
        public DateTimeOffset UpdateAt { get; init; }

        /// <summary>
        /// Gets or init field "positions".
        /// </summary>
        [JsonProperty("positions")]
        public Position[] Positions { get; init; } = [];

        /// <summary>
        /// Gets or init field "games".
        /// </summary>
        [JsonProperty("games")]
        public Game[] Games { get; init; } = [];

        /// <summary>
        /// Gets or init field "timeline".
        /// </summary>
        [JsonProperty("timeline")]
        public Timeline[] Timeline { get; set; } = [];

        /// <summary>
        /// Gets or init field "platforms".
        /// </summary>
        [JsonProperty("platforms")]
        public PlatformGroup? Platforms { get; set; }

        /// <summary>
        /// Gets or init field "ratings".
        /// </summary>
        [JsonProperty("ratings")]
        public Rating[] Ratings { get; set; } = [];
    }
}
