using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Parent platform object.
    /// </summary>
    public record ParentPlatform {
        /// <summary>
        /// Gets or init the platform parent's identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// Gets or init the platform parent's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the slug.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; init; } = string.Empty;

        /// <summary>
        /// Gets or init the platform parent's platform list.
        /// </summary>
        [JsonProperty("platforms")]
        public Platform[] Platforms { get; init; } = [];
    }
}
