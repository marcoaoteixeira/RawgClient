using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Stores.Objects;

namespace Nameless.RawgClient.Domains.Stores.Requests {
    /// <summary>
    /// Request for a list of stores.
    /// </summary>
    public sealed record GetStoresRequest
        : Request<Store>;
}
