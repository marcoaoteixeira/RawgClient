namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game parent platform description object.
    /// </summary>
    public record GameParentPlatformDescription {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
