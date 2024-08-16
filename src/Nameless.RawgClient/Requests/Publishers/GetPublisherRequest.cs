using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Publishers {
    /// <summary>
    /// Request for a list of publishers.
    /// </summary>
    public sealed record GetPublishersRequest
        : Request<Publisher>;
}
