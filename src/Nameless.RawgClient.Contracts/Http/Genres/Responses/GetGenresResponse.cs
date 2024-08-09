using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Http.Genres.Requests;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Genres.Responses {
    /// <summary>
    /// Represents the response for a list of genres.
    /// </summary>
    public sealed record GetGenresResponse : PaginableResponse<GetGenresRequest, Genre> {
    }
}
