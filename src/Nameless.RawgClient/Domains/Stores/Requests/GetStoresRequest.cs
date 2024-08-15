using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Stores.Objects;
using Nameless.RawgClient.Domains.Stores.Responses;

namespace Nameless.RawgClient.Domains.Stores.Requests {
    /// <summary>
    /// Request for a list of stores.
    /// </summary>
    public sealed record GetStoresRequest
        : Request<GetStoresResponse, Store>;
}
