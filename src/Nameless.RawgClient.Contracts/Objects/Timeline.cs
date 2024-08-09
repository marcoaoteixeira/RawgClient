using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Objects {
    /// <summary>
    /// Timeline object.
    /// </summary>
    public record Timeline {
        /// <summary>
        /// Gets or init the timeline year.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; init; }

        /// <summary>
        /// Gets or init the timeline count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; init; }
    }
}
