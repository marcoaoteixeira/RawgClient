namespace Nameless.RawgClient.Domains.Games.Objects {
    public record MetacriticPlatform {
        /// <summary>
        /// Gets or init field "metascore".
        /// </summary>
        [JsonProperty("metascore")]
        public int Metascore { get; set; }

        /// <summary>
        /// Gets or init field "url".
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonProperty("platform")]
        public MetacriticPlatformData? Platform { get; init; }
    }
}
