﻿namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// Game's parent platform item object
    /// </summary>
    public record ParentPlatformItem {
        /// <summary>
        /// Gets or init field "platform".
        /// </summary>
        [JsonPropertyName("platform")]
        public ParentPlatform? Platform { get; init; }
    }
}
