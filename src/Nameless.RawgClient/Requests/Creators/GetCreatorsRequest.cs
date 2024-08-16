using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Creators {
    /// <summary>
    /// Request for a list of creators.
    /// </summary>
    public sealed record GetCreatorsRequest
        : Request<Creator>;
}
