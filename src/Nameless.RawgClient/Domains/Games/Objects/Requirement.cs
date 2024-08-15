namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's platform requirement object.
    /// </summary>
    public record Requirement {
        /// <summary>
        /// Gets or init field "minimum".
        /// </summary>
        [JsonProperty("minimum")]
        public string Minimum { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "recommended".
        /// </summary>
        [JsonProperty("recommended")]
        public string Recommended { get; init; } = string.Empty;
    }
}
