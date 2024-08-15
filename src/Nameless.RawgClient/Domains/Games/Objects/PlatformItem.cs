namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's platform object.
    /// </summary>
    public record PlatformItem {
        /// <summary>
        /// Gets or init field "released_at".
        /// </summary>
        [JsonProperty("released_at")]
        public DateTimeOffset ReleasedAt { get; init; }

        /// <summary>
        /// Gets or init field "requirements".
        /// </summary>
        [JsonProperty("requirements")]
        public Requirement? Requirements { get; init; }

        /// <summary>
        /// Gets or init field "requirements_en".
        /// </summary>
        [JsonProperty("requirements_en")]
        public Requirement? RequirementsEn { get; init; }

        /// <summary>
        /// Gets or init field "requirements_ru".
        /// </summary>
        [JsonProperty("requirements_ru")]
        public Requirement? RequirementsRu{ get; init; }

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonProperty("platform")]
        public Platform? Platform { get; init; }
    }
}
