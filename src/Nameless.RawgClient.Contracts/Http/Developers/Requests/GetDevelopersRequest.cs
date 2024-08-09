using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Developers.Requests {
    /// <summary>
    /// Represents a request object for a list of developer.
    /// </summary>
    public sealed record GetDevelopersRequest : PaginableRequest;
}
