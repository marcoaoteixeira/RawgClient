namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's platforms object.
    /// </summary>
    public record PlatformGroup {
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
        public PlatformItem[] Results { get; init; } = [];
    }
}
