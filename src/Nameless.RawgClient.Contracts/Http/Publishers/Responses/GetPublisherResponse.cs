using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Publishers.Responses {
    /// <summary>
    /// Represents the response for a list of publishers.
    /// </summary>
    public sealed record GetPublishersResponse : PaginableResponse<Publisher>;
}
