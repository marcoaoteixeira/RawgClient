using Newtonsoft.Json;
#if NET6_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif

namespace Nameless.RawgClient.Contracts.Common {
    /// <summary>
    /// Represents an API response.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public abstract record Response<TResult>
        where TResult : class {
        /// <summary>
        /// Gets whether the request results in success or not.
        /// If this is <c>false</c>, check property <see cref="Error"/>.
        /// </summary>
#if NET6_0_OR_GREATER
        [MemberNotNullWhen(returnValue: false, nameof(Error))]
#endif
        [JsonProperty("succeeded")]
        public bool Succeeded => Error is null;

        /// <summary>
        /// Gets the results provided by the request.
        /// </summary>
        [JsonProperty("results")]
        public TResult[] Results { get; init; } = [];

        /// <summary>
        /// Gets the error message that might occur.
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; init; }
    }

    /// <summary>
    /// Represents an API response that can be paginated.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <param name="Count">Gets or init the total number of results for a given request.</param>
    /// <param name="Previous">Gets or init the previous page request parameters, if exists.</param>
    /// <param name="Next">Gets or init the next page request parameters, if exists.</param>
    public abstract record PaginableResponse<TResult>(
        [property: JsonProperty("count")] int Count = 0,
        [property: JsonProperty("previous")] Request? Previous = null,
        [property: JsonProperty("next")] Request? Next = null)
        : Response<TResult> where TResult : class;
}
