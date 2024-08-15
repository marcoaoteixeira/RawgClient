namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's added by status object.
    /// </summary>
    public record AddedByStatus {
        /// <summary>
        /// Gets or init field "yet".
        /// </summary>
        [JsonProperty("yet")]
        public int Yet { get; init; }

        /// <summary>
        /// Gets or init field "owned".
        /// </summary>
        [JsonProperty("owned")]
        public int Owned { get; init; }

        /// <summary>
        /// Gets or init field "beaten".
        /// </summary>
        [JsonProperty("beaten")]
        public int Beaten { get; init; }

        /// <summary>
        /// Gets or init field "toplay".
        /// </summary>
        [JsonProperty("toplay")]
        public int ToPlay { get; init; }

        /// <summary>
        /// Gets or init field "dropped".
        /// </summary>
        [JsonProperty("dropped")]
        public int Dropped { get; init; }

        /// <summary>
        /// Gets or init field "playing".
        /// </summary>
        [JsonProperty("playing")]
        public int Playing { get; init; }
    }
}
