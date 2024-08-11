namespace Nameless.RawgClient.Common {
    public abstract record Response<TResult> : Response
        where TResult : class {
        /// <summary>
        /// Gets or init the results.
        /// </summary>
        [JsonProperty("results")]
        public TResult[] Results { get; init; } = [];

        /// <summary>
        /// Gets or init the previous request object.
        /// </summary>
        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        public Request? Previous { get; init; }

        /// <summary>
        /// Gets or init the next request object.
        /// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public Request? Next { get; init; }

        /// <summary>
        /// Gets or init the count number of available results.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; init; }
    }
}
