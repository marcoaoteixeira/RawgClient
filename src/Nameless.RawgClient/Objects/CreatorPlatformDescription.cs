namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Creator platform description object.
    /// </summary>
    public record CreatorPlatformDescription {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
