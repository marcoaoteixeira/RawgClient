namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Game's store item object.
    /// </summary>
    public record StoreItem {
        /// <summary>
        /// Gets or init field "id".
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init field "url".
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "store".
        /// </summary>
        [JsonPropertyName("store")]
        public Store? Store { get; init; }
    }
}
