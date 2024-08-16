namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Platform market share container object.
    /// </summary>
    public record PlatformMarketShareContainer {
        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets or init field "total".
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; init; }

        /// <summary>
        /// Gets or init field "results".
        /// </summary>
        [JsonPropertyName("results")]
        public PlatformMarketShare[] Results { get; init; } = [];
    }
}
