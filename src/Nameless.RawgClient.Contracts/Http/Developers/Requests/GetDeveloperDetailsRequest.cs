using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Developers.Requests {
    /// <summary>
    /// Represents a request object for developer's details.
    /// </summary>
    public sealed record GetDeveloperDetailsRequest : Request {
        /// <summary>
        /// Gets or init the developer's identifier.
        /// </summary>
        public int Id { get; init; }
    }
}
