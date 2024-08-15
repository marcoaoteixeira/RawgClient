namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's rating object.
    /// </summary>
    public record Rating {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "title".
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets or init field "percent".
        /// </summary>
        [JsonProperty("percent")]
        public double Percent { get; init; }
    }
}
