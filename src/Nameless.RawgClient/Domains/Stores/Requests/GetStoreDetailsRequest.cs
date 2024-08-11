namespace Nameless.RawgClient.Domains.Stores.Requests {
    /// <summary>
    /// Represents a request object for store's details.
    /// </summary>
    /// <param name="Id">The store identifier.</param>
    public sealed record GetStoreDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetStoreDetailsResponse, Store>;
}
