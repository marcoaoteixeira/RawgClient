namespace Nameless.RawgClient.Common {
    /// <summary>
    /// RAWG response object.
    /// </summary>
    /// <typeparam name="TResult">Type of the response's <see cref="Results"/> field.</typeparam>
    public sealed record Response<TResult>
        where TResult : class {
        /// <summary>
        /// Gets whether the request results in success or not.
        /// If this is <c>false</c>, check property <see cref="Error"/> for more information.
        /// </summary>
        [MemberNotNullWhen(returnValue: false, nameof(Error))]
        [JsonPropertyName("succeeded")]
        public bool Succeeded => Error is null;

        /// <summary>
        /// Gets or init the error message.
        /// </summary>
        [JsonPropertyName("error")]
        public string? Error { get; init; }

        /// <summary>
        /// Gets or init the results.
        /// </summary>
        [JsonPropertyName("results")]
        public TResult[] Results { get; init; } = [];

        /// <summary>
        /// Gets or init the previous request object.
        /// </summary>
        [JsonPropertyName("previous")]
        public Request<TResult>? Previous { get; init; }

        /// <summary>
        /// Gets or init the next request object.
        /// </summary>
        [JsonPropertyName("next")]
        public Request<TResult>? Next { get; init; }

        /// <summary>
        /// Gets or init the count number of available results.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; init; }
    }
}
