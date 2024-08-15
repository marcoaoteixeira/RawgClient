using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Publishers.Objects;
using Nameless.RawgClient.Domains.Publishers.Responses;

namespace Nameless.RawgClient.Domains.Publishers.Requests {
    /// <summary>
    /// Request for publisher's details.
    /// </summary>
    /// <param name="Id">The publisher's identifier.</param>
    public sealed record GetPublisherDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetPublisherDetailsResponse, Publisher>;
}
