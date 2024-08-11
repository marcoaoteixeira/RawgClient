namespace Nameless.RawgClient.Common {
    public abstract record Response {
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
        /// Gets or init the error message.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string? Error { get; init; }
    }
}
