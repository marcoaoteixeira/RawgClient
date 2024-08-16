using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Tags.Objects;

namespace Nameless.RawgClient.Domains.Tags.Requests {
    /// <summary>
    /// Request for tag's details.
    /// </summary>
    /// <param name="Id">The tag's identifier.</param>
    public sealed record GetTagDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Tag>;
}
