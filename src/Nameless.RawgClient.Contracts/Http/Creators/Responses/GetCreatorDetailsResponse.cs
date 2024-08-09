using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Creators.Responses {
    /// <summary>
    /// Represents the response for a creator's details request.
    /// </summary>
    public sealed record GetCreatorDetailsResponse : Response<Creator>;
}
