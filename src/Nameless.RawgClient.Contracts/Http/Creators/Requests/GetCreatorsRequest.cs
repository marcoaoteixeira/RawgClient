using Nameless.RawgClient.Contracts.Common;

namespace Nameless.RawgClient.Contracts.Http.Creators.Requests {
    /// <summary>
    /// Request object used to retrieve a list of creators.
    /// </summary>
    public sealed record GetCreatorsRequest : PaginableRequest {
    }
}
