using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's developer object.
    /// </summary>
    public record Developer : Entity {
        /// <summary>
        /// Gets or init field "games_count".
        /// </summary>
        [JsonPropertyName("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonPropertyName("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "image_background".
        /// </summary>
        [JsonPropertyName("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "games".
        /// </summary>
        [JsonPropertyName("games")]
        public Game[] Games { get; init; } = [];
    }
}
