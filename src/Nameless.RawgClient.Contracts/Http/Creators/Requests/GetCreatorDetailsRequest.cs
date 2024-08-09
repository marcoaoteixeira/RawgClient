using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Creators.Requests {
    /// <summary>
    /// Request object used to retrieve a creator by its identifier.
    /// </summary>
    public sealed record GetCreatorDetailsRequest : Request {
        /// <summary>
        /// Gets or init the identifier.
        /// </summary>
        public int Id { get; init; }
    }
}
