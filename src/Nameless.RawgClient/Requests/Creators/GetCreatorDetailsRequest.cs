using Nameless.RawgClient.Common;
using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Requests.Creators {
    /// <summary>
    /// Request for creator's details.
    /// </summary>
    /// <param name="Id">The creator's identifier.</param>
    public sealed record GetCreatorDetailsRequest([property: JsonPropertyName("id")] int Id)
        : Request<Creator>;
}
