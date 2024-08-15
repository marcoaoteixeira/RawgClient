namespace Nameless.RawgClient.Common {
    /// <summary>
    /// Defines a base generic response object.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
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
        [JsonProperty("previous")]
        public Request? Previous { get; init; }

        /// <summary>
        /// Gets or init the next request object.
        /// </summary>
        [JsonProperty("next")]
        public Request? Next { get; init; }

        /// <summary>
        /// Gets or init the count number of available results.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; init; }
    }
}
