namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's platforms object.
    /// </summary>
    public record PlatformGroup {
        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets or init field "total".
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; init; }

        /// <summary>
        /// Gets or init field "results".
        /// </summary>
        [JsonProperty("results")]
        public PlatformItem[] Results { get; init; } = [];
    }
}
