namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game's platform requirement object.
    /// </summary>
    public record Requirement {
        /// <summary>
        /// Gets or init field "minimum".
        /// </summary>
        [JsonPropertyName("minimum")]
        public string Minimum { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "recommended".
        /// </summary>
        [JsonPropertyName("recommended")]
        public string Recommended { get; init; } = string.Empty;
    }
}
