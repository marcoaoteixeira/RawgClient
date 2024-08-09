using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Position object.
    /// </summary>
    public record Position {
        /// <summary>
        /// Gets the position identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets the position name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets the position slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;
    }
}
