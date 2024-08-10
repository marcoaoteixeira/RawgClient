using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Stores.Responses {
    /// <summary>
    /// Represents the response for a store's details.
    /// </summary>
    public sealed record GetStoreDetailsResponse : Response<Store>;
}
