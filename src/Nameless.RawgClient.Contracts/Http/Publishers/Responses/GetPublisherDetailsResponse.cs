using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Publishers.Responses {
    /// <summary>
    /// Represents the response for a publisher's details.
    /// </summary>
    public sealed record GetPublisherDetailsResponse : Response<Publisher>;
}
