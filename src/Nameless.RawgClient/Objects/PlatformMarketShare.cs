namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Platform market share object.
    /// </summary>
    public record PlatformMarketShare {
        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets or init field "percent".
        /// </summary>
        [JsonPropertyName("percent")]
        public decimal Percent { get; init; }

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public Platform? Platform { get; init; }
    }
}
