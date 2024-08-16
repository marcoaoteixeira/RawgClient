using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Publishers.Objects;

namespace Nameless.RawgClient.Domains.Publishers.Requests {
    /// <summary>
    /// Request for a list of publishers.
    /// </summary>
    public sealed record GetPublishersRequest
        : Request<Publisher>;
}
