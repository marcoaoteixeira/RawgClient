using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Publishers.Requests {
    /// <summary>
    /// Represents a request object for publisher's details.
    /// </summary>
    public sealed record GetPublisherDetailsRequest : Request {
        /// <summary>
        /// Gets or init the publisher's identifier.
        /// </summary>
        public int Id { get; init; }
    }
}
