using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Developer object.
    /// </summary>
    public record Developer {
        /// <summary>
        /// Gets or init the creator's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init the creator's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Gets a background image URL.
        /// </summary>
        [JsonProperty("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the creator's games count.
        /// </summary>
        [JsonProperty("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init the creator's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the developer's game list.
        /// </summary>
        [JsonProperty("games")]
        public Game[] Games { get; init; } = [];
    }
}
