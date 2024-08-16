namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Parent platform object.
    /// </summary>
    public record ParentPlatform : Entity {
        /// <summary>
        /// Gets or init field "platforms".
        /// </summary>
        [JsonPropertyName("platforms")]
        public Platform[] Platforms { get; init; } = [];
    }
}
