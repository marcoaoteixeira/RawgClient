using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Publishers.Objects {
    /// <summary>
    /// Publisher object.
    /// </summary>
    public record Publisher : Entity {
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
