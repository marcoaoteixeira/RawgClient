using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Creators.Objects;

namespace Nameless.RawgClient.Domains.Creators.Responses {
    /// <summary>
    /// Response for creator's details.
    /// </summary>
    public sealed record GetCreatorDetailsResponse
        : Response<Creator>;
}
