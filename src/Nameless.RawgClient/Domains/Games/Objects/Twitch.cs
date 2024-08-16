namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Twitch object.
    /// </summary>
    public record Twitch {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "external_id".
        /// </summary>
        [JsonPropertyName("external_id")]
        public int ExternalId { get; init; }

        /// <summary>
        /// Gets or init field "name".
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "thumbnail".
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public string ThumbnailUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "view_count".
        /// </summary>
        [JsonPropertyName("view_count")]
        public int ViewCount { get; init; }

        /// <summary>
        /// Gets or init field "language".
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "created".
        /// </summary>
        [JsonPropertyName("created")]
        public DateTimeOffset CreatedAt { get; init; }

        /// <summary>
        /// Gets or init field "published".
        /// </summary>
        [JsonPropertyName("published")]
        public DateTimeOffset PublishedAt { get; init; }
    }
}
