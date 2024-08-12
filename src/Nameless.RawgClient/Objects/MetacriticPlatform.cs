namespace Nameless.RawgClient.Objects {
    public record MetacriticPlatform {
        [JsonProperty("metascore")]
        public int Metascore { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        [JsonProperty("platform")]
        public MetacriticPlatformDescription? Platform { get; init; }
    }
}
