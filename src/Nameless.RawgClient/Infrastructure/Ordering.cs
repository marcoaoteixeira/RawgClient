namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// Describes an ordering action.
    /// </summary>
    /// <param name="OrderBy">Gets the name of the field used by the ordering parameter.</param>
    /// <param name="Descending">Whether the direction of the ordering should be descending or not.</param>
    [JsonConverter(typeof(OrderingJsonConverter))]
    public readonly record struct Ordering(string OrderBy, bool Descending) {
        /// <summary>
        /// Whether a value is present for this ordering action.
        /// </summary>
        public bool IsEmpty => string.IsNullOrWhiteSpace(OrderBy);

        /// <summary>
        /// Implicit converts a <see cref="Ordering"/> object into a <see cref="string"/>.
        /// </summary>
        /// <param name="ordering">The <see cref="Ordering"/> instance.</param>
        public static implicit operator string(Ordering ordering)
            => ordering.Descending ? $"-{ordering.OrderBy}" : ordering.OrderBy;

        /// <summary>
        /// Implicit converts a <see cref="string"/> into a <see cref="Ordering"/> object.
        /// </summary>
        /// <param name="value">The ordering string representation.</param>
        public static implicit operator Ordering(string? value) {
            if (string.IsNullOrWhiteSpace(value)) {
                return new Ordering();
            }

            return value.StartsWith("-", StringComparison.OrdinalIgnoreCase)
                ? new Ordering(OrderBy: value[1..], Descending: true)
                : new Ordering(OrderBy: value, Descending: false);
        }
    }
}
