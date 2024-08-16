namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Platform object.
    /// </summary>
    public record Platform : Entity {
        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games_count".
        /// </summary>
        [JsonPropertyName("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init field "image_background".
        /// </summary>
        [JsonPropertyName("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonPropertyName("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "year_start".
        /// </summary>
        [JsonPropertyName("year_start")]
        public int? YearStart { get; init; }

        /// <summary>
        /// Gets or init field "year_end".
        /// </summary>
        [JsonPropertyName("year_end")]
        public int? YearEnd { get; init; }

        /// <summary>
        /// Gets or init field "games".
        /// </summary>
        [JsonPropertyName("games")]
        public Game[] Games { get; init; } = [];
    }
}
