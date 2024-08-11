namespace Nameless.RawgClient.Common {
    /// <summary>
    /// Defines a base request object.
    /// </summary>
    public abstract record Request {
        private const string PageNumberKey = "page";
        private const string PageSizeKey = "page_size";
        private const string OrderingKey = "ordering";

        /// <summary>
        /// Gets or init the page number.
        /// </summary>
        [JsonProperty(PageNumberKey, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; init; }

        /// <summary>
        /// Gets or init the page size.
        /// </summary>
        [JsonProperty(PageSizeKey, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; init; }

        /// <summary>
        /// Gets or init the ordering.
        /// </summary>
        [JsonProperty(OrderingKey, NullValueHandling = NullValueHandling.Ignore)]
        public Ordering? Ordering { get; init; }

        /// <summary>
        /// Retrieves a dictionary representing this request as query parameters.
        /// </summary>
        /// <returns>A dictionary representing this request as query parameters.</returns>
        public virtual Dictionary<string, object[]> GetQueryParams() {
            var result = new Dictionary<string, object[]>();

            if (PageNumber.HasValue) {
                result[PageNumberKey] = [PageNumber.Value];
            }

            if (PageSize.HasValue) {
                result[PageSizeKey] = [PageSize.Value];
            }

            var ordering = Ordering.GetValueOrDefault();
            if (!ordering.IsEmpty) {
                result[OrderingKey] = [(string)ordering];
            }

            return result;
        }
    }
}
