namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// YouTube object.
    /// </summary>
    public record YouTube {
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
        /// Gets or init field "channel_id".
        /// </summary>
        [JsonPropertyName("channel_id")]
        public int ChannelId { get; init; }

        /// <summary>
        /// Gets or init field "channel_title".
        /// </summary>
        [JsonPropertyName("channel_title")]
        public string ChannelTitle { get; init; } = string.Empty;

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
        /// Gets or init field "view_count".
        /// </summary>
        [JsonPropertyName("view_count")]
        public int ViewCount { get; init; }

        /// <summary>
        /// Gets or init field "comments_count".
        /// </summary>
        [JsonPropertyName("comments_count")]
        public int CommentsCount { get; init; }

        /// <summary>
        /// Gets or init field "like_count".
        /// </summary>
        [JsonPropertyName("like_count")]
        public int LikeCount { get; init; }

        /// <summary>
        /// Gets or init field "dislike_count".
        /// </summary>
        [JsonPropertyName("dislike_count")]
        public int DislikeCount { get; init; }

        /// <summary>
        /// Gets or init field "favorite_count".
        /// </summary>
        [JsonPropertyName("favorite_count")]
        public int FavoriteCount { get; init; }

        /// <summary>
        /// Gets or init field "thumbnails".
        /// </summary>
        [JsonPropertyName("thumbnails")]
        public object? Thumbnails { get; init; }

        /// <summary>
        /// Gets or init field "created".
        /// </summary>
        [JsonPropertyName("created")]
        public DateTimeOffset CreatedAt { get; init; }
    }
}
