using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Creators.Responses {
    /// <summary>
    /// Represents the response for a request of a creators list.
    /// </summary>
    public record GetCreatorsResponse : PaginableResponse<Creator>;
}