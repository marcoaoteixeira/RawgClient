namespace Nameless.RawgClient.Objects {
    public record Rating {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("title")]
        public string Title { get; init; } = string.Empty;

        [JsonProperty("count")]
        public int Count { get; init; }

        [JsonProperty("percent")]
        public double Percent { get; init; }
    }
}
