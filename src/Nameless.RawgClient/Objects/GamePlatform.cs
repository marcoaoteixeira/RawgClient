namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game parent platform object.
    /// </summary>
    public record GamePlatform {
        /// <summary>
        /// Gets the platform.
        /// </summary>
        [JsonProperty("platform")]
        public Platform? Platform { get; init; }
    }
}
