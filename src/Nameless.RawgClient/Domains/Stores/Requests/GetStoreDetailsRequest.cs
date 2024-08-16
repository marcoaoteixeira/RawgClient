using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Stores.Objects;

namespace Nameless.RawgClient.Domains.Stores.Requests {
    /// <summary>
    /// Request for store's details.
    /// </summary>
    /// <param name="Id">The store's identifier.</param>
    public sealed record GetStoreDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Store>;
}
