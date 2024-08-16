using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Stores {
    /// <summary>
    /// Request for a list of stores.
    /// </summary>
    public sealed record GetStoresRequest
        : Request<Store>;
}
