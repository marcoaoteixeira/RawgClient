namespace Nameless.RawgClient.Contracts.Common {
    /// <summary>
    /// Base object to create page-aware requests.
    /// </summary>
    public abstract record PaginableRequest : Request {
        /// <summary>
        /// Gets or init the number of the page.
        /// </summary>
        public int PageNumber { get; init; } = 1;

        /// <summary>
        /// Gets or init the size of the page.
        /// </summary>
        public int PageSize { get; init; } = 10;

        /// <summary>
        /// Gets or init the ordering direction.
        /// </summary>
        public OrderDirection OrderDirection { get; init; }

        /// <summary>
        /// Gets or init the ordering field.
        /// </summary>
        public string? OrderBy { get; init; }

        /// <inheritdoc />
        public override Dictionary<string, object[]> ToQueryParams() {
            var result = new Dictionary<string, object[]> {
                { "page", [PageNumber] },
                { "page_size", [PageSize] },
            };

            if (!string.IsNullOrWhiteSpace(OrderBy)) {
                var order = OrderDirection == OrderDirection.Descending
                    ? $"-{OrderBy}"
                    : OrderBy;

                result["ordering"] = [order];
            }

            return result;
        }
    }
}
