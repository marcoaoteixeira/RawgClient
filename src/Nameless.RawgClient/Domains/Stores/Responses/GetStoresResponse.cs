using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Stores.Objects;

namespace Nameless.RawgClient.Domains.Stores.Responses {
    /// <summary>
    /// Response for a list of stores.
    /// </summary>
    public sealed record GetStoresResponse
        : Response<Store>;
}
