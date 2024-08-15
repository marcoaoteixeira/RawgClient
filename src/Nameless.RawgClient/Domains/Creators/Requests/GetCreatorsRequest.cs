using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Creators.Objects;
using Nameless.RawgClient.Domains.Creators.Responses;

namespace Nameless.RawgClient.Domains.Creators.Requests {
    /// <summary>
    /// Request for a list of creators.
    /// </summary>
    public sealed record GetCreatorsRequest
        : Request<GetCreatorsResponse, Creator>;
}
