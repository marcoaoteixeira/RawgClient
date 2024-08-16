namespace Nameless.RawgClient.Domains.Common {
    /// <summary>
    /// Represents an entity object from where most other objects inherit.
    /// </summary>
    public abstract record Entity {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "name".
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "slug".
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
