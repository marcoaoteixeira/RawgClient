using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Tags.Requests {
    /// <summary>
    /// Represents a request object for tag's details.
    /// </summary>
    public sealed record GetTagDetailsRequest : Request {
        /// <summary>
        /// Gets or init the tag's identifier.
        /// </summary>
        public int Id { get; init; }
    }
}
