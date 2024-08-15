using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's tag object.
    /// </summary>
    public record Tag : Entity {
        /// <summary>
        /// Gets or init field "language".
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games_count".
        /// </summary>
        [JsonProperty("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init field "image_background".
        /// </summary>
        [JsonProperty("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;
    }
}
