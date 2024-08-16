namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's timeline object.
    /// </summary>
    public record Timeline {
        /// <summary>
        /// Gets or init field "year".
        /// </summary>
        [JsonPropertyName("year")]
        public int Year { get; init; }

        /// <summary>
        /// Gets or init field "count".
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; init; }
    }
}
