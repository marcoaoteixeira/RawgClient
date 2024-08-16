using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Publishers.Objects;

namespace Nameless.RawgClient.Domains.Publishers.Requests {
    /// <summary>
    /// Request for publisher's details.
    /// </summary>
    /// <param name="Id">The publisher's identifier.</param>
    public sealed record GetPublisherDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Publisher>;
}
