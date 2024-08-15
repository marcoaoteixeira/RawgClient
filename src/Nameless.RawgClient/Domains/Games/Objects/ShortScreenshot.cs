namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's short screenshot object.
    /// </summary>
    public record ShortScreenshot {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonProperty("image")]
        public string ImageUrl { get; init; } = string.Empty;
    }
}
