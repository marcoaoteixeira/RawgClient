using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Stores.Objects;

namespace Nameless.RawgClient.Domains.Stores.Responses {
    /// <summary>
    /// Response for store's details.
    /// </summary>
    public sealed record GetStoreDetailsResponse
        : Response<Store>;
}
