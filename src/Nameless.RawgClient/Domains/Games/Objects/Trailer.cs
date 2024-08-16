namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's trailer object.
    /// </summary>
    public record Trailer {
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
        /// Gets or init field "preview".
        /// </summary>
        [JsonPropertyName("preview")]
        public string PreviewImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "data".
        /// </summary>
        [JsonPropertyName("data")]
        public TrailerOptionCollection Data { get; init; } = [];
    }
}
