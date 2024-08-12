namespace Nameless.RawgClient.Objects {
    public record EsrbRating {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
