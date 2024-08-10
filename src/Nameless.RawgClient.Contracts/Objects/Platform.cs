using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Platform object.
    /// </summary>
    public record Platform {
        /// <summary>
        /// Gets or init the platform's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init the platform's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the platform games count.
        /// </summary>
        [JsonProperty("games_count")]
        public int GamesCount { get; init; }

        /// <summary>
        /// Gets or init the background image URL.
        /// </summary>
        [JsonProperty("image_background")]
        public string BackgroundImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the image URL.
        /// </summary>
        [JsonProperty("image")]
        public string ImageUrl { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the platform start year.
        /// </summary>
        [JsonProperty("year_start")]
        public int? YearStart { get; init; }

        /// <summary>
        /// Gets or init the platform end year.
        /// </summary>
        [JsonProperty("year_end")]
        public int? YearEnd { get; init; }

        /// <summary>
        /// Gets or init the platform's game list.
        /// </summary>
        [JsonProperty("games")]
        public Game[] Games { get; init; } = [];
    }
}
