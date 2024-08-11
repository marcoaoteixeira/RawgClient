namespace Nameless.RawgClient.Domains.Stores.Requests {
    /// <summary>
    /// Represents a request object for a list of store.
    /// </summary>
    public sealed record GetStoresRequest
        : Request<GetStoresResponse, Store>;
}
