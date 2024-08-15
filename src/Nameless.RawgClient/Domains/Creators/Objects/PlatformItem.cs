namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's platform item object.
    /// </summary>
    public record PlatformItem {
        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets or init field "percent".
        /// </summary>
        [JsonProperty("percent")]
        public decimal Percent { get; init; }

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonProperty("platform")]
        public Platform? Platform { get; init; }
    }
}
