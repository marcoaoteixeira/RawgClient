namespace Nameless.RawgClient.Options {
    /// <summary>
    /// Object to be used in conjunction with configuration.
    /// </summary>
    public sealed record RawgOptions {
        /// <summary>
        /// Returns a default instance of <see cref="RawgOptions"/>.
        /// </summary>
        public static RawgOptions Default => new();

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        public string ApiKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the HTTP scheme being used.
        /// </summary>
        public string Scheme { get; set; } = "https";

        /// <summary>
        /// Gets or sets the RAWG host.
        /// </summary>
        public string Host { get; set; } = "api.rawg.io";

        /// <summary>
        /// Gets or sets the correct port to connect to the API.
        /// </summary>
        public int Port { get; set; } = 443;
    }
}
