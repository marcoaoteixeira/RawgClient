namespace Nameless.RawgClient.Objects {
    public record Requirement {
        [JsonProperty("minimum")]
        public string Minimum { get; init; } = string.Empty;

        [JsonProperty("recommended")]
        public string Recommended { get; init; } = string.Empty;
    }
}
