using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Publishers.Objects;

namespace Nameless.RawgClient.Domains.Publishers.Responses {
    /// <summary>
    /// Response for a list of publishers.
    /// </summary>
    public sealed record GetPublishersResponse
        : Response<Publisher>;
}
