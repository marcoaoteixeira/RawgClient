using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Tags.Objects;
using Nameless.RawgClient.Domains.Tags.Responses;

namespace Nameless.RawgClient.Domains.Tags.Requests {
    /// <summary>
    /// Request for tag's details.
    /// </summary>
    /// <param name="Id">The tag's identifier.</param>
    public sealed record GetTagDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetTagDetailsResponse, Tag>;
}
