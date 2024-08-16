namespace Nameless.RawgClient.Domains.Games.Objects {
    public record MetacriticPlatform {
        /// <summary>
        /// Gets or init field "metascore".
        /// </summary>
        [JsonPropertyName("metascore")]
        public int Metascore { get; set; }

        /// <summary>
        /// Gets or init field "url".
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public MetacriticPlatformData? Platform { get; init; }
    }
}
