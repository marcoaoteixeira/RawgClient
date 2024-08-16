using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Publishers.Objects {
    /// <summary>
    /// Publisher's game object.
    /// </summary>
    public record Game : Entity {
        /// <summary>
        /// Gets or init field "added".
        /// </summary>
        [JsonPropertyName("added")]
        public int Added { get; init; }
    }
}
