namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// Represents a generic error with a message.
    /// </summary>
    public record ResponseError {
        /// <summary>
        /// Gets the reason of the error.
        /// </summary>
        public string? Reason { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="ResponseError"/>
        /// </summary>
        /// <param name="reason">The reason of the error.</param>
        public ResponseError(string reason) {
            Reason = reason;
        }
    }
}
