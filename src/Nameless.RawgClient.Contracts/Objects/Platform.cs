using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Platform object.
    /// </summary>
    public record Platform {
        /// <summary>
        /// Gets the platform's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the platform's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
