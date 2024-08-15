using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Stores.Objects;
using Nameless.RawgClient.Domains.Stores.Responses;

namespace Nameless.RawgClient.Domains.Stores.Requests {
    /// <summary>
    /// Request for store's details.
    /// </summary>
    /// <param name="Id">The store's identifier.</param>
    public sealed record GetStoreDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetStoreDetailsResponse, Store>;
}
