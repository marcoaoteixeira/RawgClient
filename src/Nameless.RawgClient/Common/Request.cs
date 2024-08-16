using Nameless.RawgClient.Infrastructure;

namespace Nameless.RawgClient.Common {
    /// <summary>
    /// Defines the abstract structure for a request object.
    /// </summary>
    public abstract record Request {
        private const string PageNumberKey = "page";
        private const string PageSizeKey = "page_size";
        private const string OrderingKey = "ordering";

        /// <summary>
        /// Gets or init the page number.
        /// </summary>
        [JsonPropertyName(PageNumberKey)]
        public int? PageNumber { get; init; }

        /// <summary>
        /// Gets or init the page size.
        /// </summary>
        [JsonPropertyName(PageSizeKey)]
        public int? PageSize { get; init; }

        /// <summary>
        /// Gets or init the ordering.
        /// </summary>
        [JsonPropertyName(OrderingKey)]
        public Ordering? Ordering { get; init; }

        /// <summary>
        /// Retrieves a dictionary representing this request as query parameters.
        /// </summary>
        /// <returns>A dictionary representing this request as query parameters.</returns>
        public virtual Dictionary<string, object[]> GetQueryParams() {
            var result = new Dictionary<string, object[]>();

            if (PageNumber is > 0) {
                result[PageNumberKey] = [PageNumber.Value];
            }

            if (PageSize is > 0) {
                result[PageSizeKey] = [PageSize.Value];
            }

            var ordering = Ordering.GetValueOrDefault();
            if (!ordering.IsEmpty) {
                result[OrderingKey] = [(string)ordering];
            }

            return result;
        }
    }

    /// <summary>
    /// Generic version of <see cref="Request"/> object.
    /// </summary>
    /// <typeparam name="TResult">The type of the result inside the response.</typeparam>
    public abstract record Request<TResult> : Request
        where TResult : class;
}
