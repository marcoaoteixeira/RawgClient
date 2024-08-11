namespace Nameless.RawgClient {
    /// <summary>
    /// A DTO object to transfer data from RAWG API to the actual response object.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    internal sealed record Paginable<TResult>
        where TResult : class {
        /// <summary>
        /// Gets the total count of objects.
        /// </summary>
        [JsonProperty("count")]
        internal int Count { get; set; }

        /// <summary>
        /// Gets the previous query.
        /// </summary>
        [JsonProperty("previous")]
        internal string? PreviousQuery { get; set; }

        /// <summary>
        /// Gets the next query.
        /// </summary>
        [JsonProperty("next")]
        internal string? NextQuery { get; set; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        [JsonProperty("results")]
        internal TResult[] Results { get; set; } = [];
    }
}
