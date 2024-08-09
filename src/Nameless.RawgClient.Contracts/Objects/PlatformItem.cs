using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Platform (collection) item object.
    /// </summary>
    public record PlatformItem {
        /// <summary>
        /// Gets the count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }

        /// <summary>
        /// Gets the percent.
        /// </summary>
        [JsonProperty("percent")]
        public decimal Percent { get; init; }

        /// <summary>
        /// Gets the platform.
        /// </summary>
        [JsonProperty("platform")]
        public Platform Platform { get; init; } = new();
    }
}
