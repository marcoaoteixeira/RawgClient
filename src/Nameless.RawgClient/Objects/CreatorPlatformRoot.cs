namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Creator's platform root object.
    /// </summary>
    public record CreatorPlatformRoot {
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
        public CreatorPlatform[] Results { get; init; } = [];
    }
}
