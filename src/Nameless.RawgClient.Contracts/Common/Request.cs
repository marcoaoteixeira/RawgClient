namespace Nameless.RawgClient.Contracts.Common {
    /// <summary>
    /// Represents the base request object.
    /// </summary>
    public abstract record Request {
        /// <summary>
        /// Retrieves a dictionary that represents this request as query parameters.
        /// </summary>
        /// <returns>A dictionary.</returns>
        public virtual Dictionary<string, object[]> ToQueryParams() => [];
    }
}
