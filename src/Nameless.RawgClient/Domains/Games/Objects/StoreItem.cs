namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's store item object.
    /// </summary>
    public record StoreItem {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "url".
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "store".
        /// </summary>
        [JsonProperty("store")]
        public Store? Store { get; init; }
    }
}
