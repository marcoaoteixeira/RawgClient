using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Publishers.Objects;
using Nameless.RawgClient.Domains.Publishers.Responses;

namespace Nameless.RawgClient.Domains.Publishers.Requests {
    /// <summary>
    /// Request for a list of publishers.
    /// </summary>
    public sealed record GetPublishersRequest
        : Request<GetPublishersResponse, Publisher>;
}
