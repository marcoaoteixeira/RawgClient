using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's publisher object.
    /// </summary>
    public record Publisher : Entity {
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
