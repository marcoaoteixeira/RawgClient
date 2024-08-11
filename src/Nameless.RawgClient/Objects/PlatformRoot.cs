namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Platform root object.
    /// </summary>
    public record PlatformRoot {
        /// <summary>
        /// Gets the count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets the total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; init; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        [JsonProperty("results")]
        public PlatformItem[] Results { get; init; } = [];
    }
}
