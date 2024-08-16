using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Creators.Objects {
    /// <summary>
    /// Creator's game object.
    /// </summary>
    public record Game : Entity {
        /// <summary>
        /// Gets or init field "added".
        /// </summary>
        [JsonPropertyName("added")]
        public int Added { get; init; }
    }
}
