using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Genres.Responses {
    /// <summary>
    /// Represents the response for a genre's details.
    /// </summary>
    public sealed record GetGenreDetailsResponse : Response<Genre> {
    }
}
