using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Creators.Objects;

namespace Nameless.RawgClient.Domains.Creators.Requests {
    /// <summary>
    /// Request for a list of creators.
    /// </summary>
    public sealed record GetCreatorsRequest
        : Request<Creator>;
}
