using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Genres.Objects {
    /// <summary>
    /// Genre's game object.
    /// </summary>
    public record Game : Entity {
        /// <summary>
        /// Gets or init field "added".
        /// </summary>
        [JsonProperty("added")]
        public int Added { get; init; }
    }
}
