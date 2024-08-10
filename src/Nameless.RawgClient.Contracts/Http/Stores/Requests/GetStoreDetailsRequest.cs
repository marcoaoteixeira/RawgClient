using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Http.Stores.Requests {
    /// <summary>
    /// Represents a request object for store's details.
    /// </summary>
    /// <param name="Id">The store identifier.</param>
    public sealed record GetStoreDetailsRequest([property: JsonProperty("id")] int Id) : Request;
}
