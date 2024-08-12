namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game parent platform object.
    /// </summary>
    public record GameParentPlatform {
        /// <summary>
        /// Gets the platform.
        /// </summary>
        [JsonProperty("platform")]
        public GameParentPlatformDescription? Platform { get; init; }
    }
}
