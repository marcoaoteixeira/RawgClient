namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Added by status object.
    /// </summary>
    public record AddedByStatus {
        /// <summary>
        /// Gets or init field "yet".
        /// </summary>
        [JsonPropertyName("yet")]
        public int Yet { get; init; }

        /// <summary>
        /// Gets or init field "owned".
        /// </summary>
        [JsonPropertyName("owned")]
        public int Owned { get; init; }

        /// <summary>
        /// Gets or init field "beaten".
        /// </summary>
        [JsonPropertyName("beaten")]
        public int Beaten { get; init; }

        /// <summary>
        /// Gets or init field "toplay".
        /// </summary>
        [JsonPropertyName("toplay")]
        public int ToPlay { get; init; }

        /// <summary>
        /// Gets or init field "dropped".
        /// </summary>
        [JsonPropertyName("dropped")]
        public int Dropped { get; init; }

        /// <summary>
        /// Gets or init field "playing".
        /// </summary>
        [JsonPropertyName("playing")]
        public int Playing { get; init; }
    }
}
