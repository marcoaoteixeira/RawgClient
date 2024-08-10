using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Stores.Responses {
    /// <summary>
    /// Represents the response for a list of stores.
    /// </summary>
    public sealed record GetStoresResponse : PaginableResponse<Store>;
}
