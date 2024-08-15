using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Publishers.Objects;

namespace Nameless.RawgClient.Domains.Publishers.Responses {
    /// <summary>
    /// Response for publisher's details.
    /// </summary>
    public sealed record GetPublisherDetailsResponse
        : Response<Publisher>;
}
