using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Games {
    /// <summary>
    /// Request for a list of game's reddit posts.
    /// </summary>
    /// <param name="Id">The game's identifier.</param>
    public record GetGameRedditPostsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Reddit>;
}
