namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's rating object.
    /// </summary>
    public record Rating {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "title".
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets or init field "percent".
        /// </summary>
        [JsonPropertyName("percent")]
        public double Percent { get; init; }
    }
}
