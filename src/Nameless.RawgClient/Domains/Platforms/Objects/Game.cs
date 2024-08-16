using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Platforms.Objects {
    /// <summary>
    /// Platform's game object.
    /// </summary>
    public record Game : Entity {
        /// <summary>
        /// Gets or init field "added".
        /// </summary>
        [JsonPropertyName("added")]
        public int Added { get; init; }
    }
}
