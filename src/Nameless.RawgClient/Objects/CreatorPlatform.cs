namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Creator platform object.
    /// </summary>
    public record CreatorPlatform {
        /// <summary>
        /// Gets the count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets the percent.
        /// </summary>
        [JsonProperty("percent")]
        public decimal Percent { get; init; }

        /// <summary>
        /// Gets the platform.
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public CreatorPlatformDescription? Platform { get; init; }
    }
}
