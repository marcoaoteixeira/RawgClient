using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Games.Objects;

namespace Nameless.RawgClient.Domains.Games.Responses {
    /// <summary>
    /// Response for game's details.
    /// </summary>
    public record GetGameDetailsResponse
        : Response<Game>;
}
