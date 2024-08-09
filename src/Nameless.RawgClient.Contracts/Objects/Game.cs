using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Game object.
    /// </summary>
    public record Game {
        /// <summary>
        /// Gets the game's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the game's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Gets the added param.
        /// </summary>
        [JsonProperty("added")]
        public int Added { get; init; }
    }
}
