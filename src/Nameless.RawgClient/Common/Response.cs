namespace Nameless.RawgClient.Common {
    /// <summary>
    /// Defines a base response object.
    /// </summary>
    public abstract record Response {
        /// <summary>
        /// Gets whether the request results was successful or not.
        /// If this is <c>false</c>, check property <see cref="Error"/> for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        [MemberNotNullWhen(returnValue: false, nameof(Error))]
#endif
        [JsonProperty("succeeded")]
        public bool Succeeded => Error is null;

        /// <summary>
        /// Gets or init the error message.
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; init; }
    }
}
