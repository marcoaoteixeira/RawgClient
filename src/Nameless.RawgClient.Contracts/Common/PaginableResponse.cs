namespace Nameless.RawgClient.Contracts.Common {
    /// <summary>
    /// Base object to create page-aware responses.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <typeparam name="TRequest">The type of the request.</typeparam>
    public abstract record PaginableResponse<TRequest, TResult> : Response<TResult[]>
        where TRequest : PaginableRequest
        where TResult : class {
        /// <summary>
        /// Gets or init the count.
        /// </summary>
        public int Count { get; init; }

        /// <summary>
        /// Gets or init the previous request info.
        /// </summary>
        public TRequest? Previous { get; init; }

        /// <summary>
        /// Gets or init the next request info.
        /// </summary>
        public TRequest? Next { get; init; }
    }
}
