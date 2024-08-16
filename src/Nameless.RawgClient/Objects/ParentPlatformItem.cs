namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Parent platform item object
    /// </summary>
    public record ParentPlatformItem {
        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public ParentPlatform? Platform { get; init; }
    }
}
