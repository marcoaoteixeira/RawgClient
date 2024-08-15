using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Creators.Objects;

namespace Nameless.RawgClient.Domains.Creators.Responses {
    /// <summary>
    /// Response for a list of creators.
    /// </summary>
    public sealed record GetCreatorsResponse
        : Response<Creator>;
}
