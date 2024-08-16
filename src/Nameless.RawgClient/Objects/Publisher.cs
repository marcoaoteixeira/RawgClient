namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Publisher object.
    /// </summary>
    public record Publisher : Entity {
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
        /// Gets or init field "image_background".
        /// </summary>
        [JsonPropertyName("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games".
        /// </summary>
        [JsonPropertyName("games")]
        public Game[] Games { get; init; } = [];
    }
}
