using Nameless.RawgClient.Domains.Common;

namespace Nameless.RawgClient.Domains.Platforms.Objects {
    /// <summary>
    /// Platform's parent platform object.
    /// </summary>
    public record ParentPlatform : Entity {
        /// <summary>
        /// Gets or init field "platforms".
        /// </summary>
        [JsonProperty("platforms")]
        public Platform[] Platforms { get; init; } = [];
    }
}
