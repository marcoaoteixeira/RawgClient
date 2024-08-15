using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Stores.Objects {
    /// <summary>
    /// Store object.
    /// </summary>
    public record Store : Entity {
        /// <summary>
        /// Gets or init field "domain".
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "image_background".
        /// </summary>
        [JsonProperty("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games_count".
        /// </summary>
        [JsonProperty("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init field "description".
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games".
        /// </summary>
        [JsonProperty("games")]
        public Game[] Games { get; init; } = [];
    }
}
