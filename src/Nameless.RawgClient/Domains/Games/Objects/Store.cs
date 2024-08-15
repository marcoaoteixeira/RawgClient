using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's store object.
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
    }
}
