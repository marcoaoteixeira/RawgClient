namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// Trailer object compose of resolution and URL fields.
    /// </summary>
    public record TrailerOption {
        /// <summary>
        /// Gets or init the resolution associated with the trailer.
        /// </summary>
        public string Resolution { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the URL to the trailer.
        /// </summary>
        public string Url { get; init; } = string.Empty;
    }
}
