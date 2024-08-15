using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's platform object.
    /// </summary>
    public record Platform : Entity {
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

        /// <summary>
        /// Gets or init field "image".
        /// </summary>
        [JsonProperty("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init field "year_start".
        /// </summary>
        [JsonProperty("year_start")]
        public int YearStart { get; init; }

        /// <summary>
        /// Gets or init field "year_end".
        /// </summary>
        [JsonProperty("year_end")]
        public int YearEnd { get; init; }
    }
}
