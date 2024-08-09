using Newtonsoft.Json;

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

    /// <summary>
    /// Base object to create page-aware requests.
    /// </summary>
    /// <param name="PageNumber">Gets or init the number of the page.</param>
    /// <param name="PageSize">Gets or init the size of the page.</param>
    public abstract record PaginableRequest(
        [property: JsonProperty("page")] int PageNumber = 1,
        [property: JsonProperty("page_size")] int PageSize = 10) : Request {
        /// <inheritdoc />
        public override Dictionary<string, object[]> ToQueryParams()
            => new() {
                { "page", [PageNumber] },
                { "page_size", [PageSize] },
            };
    }
}
