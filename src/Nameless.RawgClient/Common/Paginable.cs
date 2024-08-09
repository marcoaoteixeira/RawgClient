using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Common {
    /// <summary>
    /// Represents a page of results.
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

        internal TResponse CreateResponse<TRequest, TResponse>(TRequest request)
            where TRequest : PaginableRequest
            where TResponse : PaginableResponse<TRequest, TResult>, new()
            => new() {
                Count = Count,
                Previous = PreviousQuery is not null
                    ? request with { PageNumber = request.PageNumber - 1 }
                    : null,
                Next = NextQuery is not null
                    ? request with { PageNumber = request.PageNumber + 1 }
                    : null,
                Result = Results
            };
    }
}
