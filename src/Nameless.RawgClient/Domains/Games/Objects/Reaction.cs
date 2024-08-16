namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Reaction object.
    /// </summary>
    public record Reaction {
        /// <summary>
        /// Gets or init the type.
        /// </summary>
        public string Type { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the value.
        /// </summary>
        public int Value { get; init; }
    }
}
