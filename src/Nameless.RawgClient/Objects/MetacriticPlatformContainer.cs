namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Metacritic platform (container) object.
    /// </summary>
    public record MetacriticPlatformContainer {
        /// <summary>
        /// Gets or init field "metascore".
        /// </summary>
        [JsonPropertyName("metascore")]
        public int Metascore { get; set; }

        /// <summary>
        /// Gets or init field "url".
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public MetacriticPlatform? Platform { get; init; }
    }
}
