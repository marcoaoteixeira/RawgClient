namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// Describes an ordering action.
    /// </summary>
    /// <param name="OrderBy">The field that will be used to order the query.</param>
    /// <param name="Descending">Whether the direction of the ordering should be descending or not.</param>
    public readonly record struct Ordering(OrderingOptions OrderBy, bool Descending) {
        private const string DescendingToken = "-";

        /// <summary>
        /// Whether a value is present for this ordering action.
        /// </summary>
        public bool IsEmpty => OrderBy == OrderingOptions.None;

        /// <summary>
        /// Retrieves the <see cref="string"/> representation for this ordering value.
        /// </summary>
        /// <returns>A <see cref="string"/> representation for this ordering value</returns>
        public string GetStringValue()
            => OrderBy != OrderingOptions.None
                ? $"{(Descending ? DescendingToken : string.Empty)}{OrderBy.GetDescription()}"
                : string.Empty;

        /// <summary>
        /// Tries parse the <see cref="string"/> as an <see cref="Ordering"/> value.
        /// </summary>
        /// <param name="value">The <see cref="string"/> value.</param>
        /// <param name="ordering">The output <see cref="Ordering"/> value.</param>
        /// <returns><c>true</c> if success; otherwise <c>false</c>.</returns>
        public static bool TryParse(string? value, out Ordering ordering) {
            ordering = new Ordering();

            if (string.IsNullOrWhiteSpace(value) || value == DescendingToken) {
                return false;
            }

            var isDescending = value.StartsWith(DescendingToken, StringComparison.CurrentCultureIgnoreCase);
            var field = isDescending ? value[1..] : value;

            if (Enum.TryParse<OrderingOptions>(field, ignoreCase: true, out var orderingOptions)) {
                ordering = new Ordering(orderingOptions, isDescending);
            }

            return !ordering.IsEmpty;
        }
    }
}
