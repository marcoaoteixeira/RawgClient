namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's screenshot object.
    /// </summary>
    public record Screenshot {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonPropertyName("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "width".
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; init; }

        /// <summary>
        /// Gets or init field "height".
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; init; }

        /// <summary>
        /// Gets or init field "is_deleted".
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool IsDeleted { get; init; }
    }
}
