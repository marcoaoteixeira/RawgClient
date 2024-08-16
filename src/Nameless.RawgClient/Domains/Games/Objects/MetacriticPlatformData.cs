namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's Metacritic platform data object.
    /// </summary>
    public record MetacriticPlatformData {
        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public int Platform { get; init; }

        /// <summary>
        /// Gets or init field "name".
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "slug".
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
