namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game's platform object.
    /// </summary>
    public record PlatformItem {
        /// <summary>
        /// Gets or init field "released_at".
        /// </summary>
        [JsonPropertyName("released_at")]
        public DateTimeOffset ReleasedAt { get; init; }

        /// <summary>
        /// Gets or init field "requirements".
        /// </summary>
        [JsonPropertyName("requirements")]
        public Requirement? Requirements { get; init; }

        /// <summary>
        /// Gets or init field "requirements_en".
        /// </summary>
        [JsonPropertyName("requirements_en")]
        public Requirement? RequirementsEn { get; init; }

        /// <summary>
        /// Gets or init field "requirements_ru".
        /// </summary>
        [JsonPropertyName("requirements_ru")]
        public Requirement? RequirementsRu { get; init; }

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public Platform? Platform { get; init; }
    }
}
