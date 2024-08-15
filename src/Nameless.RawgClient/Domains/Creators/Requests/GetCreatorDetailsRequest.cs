using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.Creators.Objects;
using Nameless.RawgClient.Domains.Creators.Responses;

namespace Nameless.RawgClient.Domains.Creators.Requests {
    /// <summary>
    /// Request for creator's details.
    /// </summary>
    /// <param name="Id">The creator's identifier.</param>
    public sealed record GetCreatorDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetCreatorDetailsResponse, Creator>;
}
