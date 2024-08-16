namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Reddit object.
    /// </summary>
    public record Reddit {
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
        /// Gets or init field "text".
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonPropertyName("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "url".
        /// </summary>
        [JsonPropertyName("url")]
        public string RedditUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "username".
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "name".
        /// </summary>
        [JsonPropertyName("username_url")]
        public string UserProfileUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "created".
        /// </summary>
        [JsonPropertyName("created")]
        public DateTimeOffset CreatedAt { get; init; }
    }
}
