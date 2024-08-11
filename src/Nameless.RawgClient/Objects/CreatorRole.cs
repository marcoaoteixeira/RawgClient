namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Creator role object.
    /// </summary>
    public record CreatorRole {
        /// <summary>
        /// Gets the creator's role identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the creator's role name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
