namespace Nameless.RawgClient.Domains.Developers.Requests {
    /// <summary>
    /// Represents a request object for developer's details.
    /// </summary>
    /// <param name="Id">The developer identifier.</param>
    public sealed record GetDeveloperDetailsRequest([property: JsonProperty("id")] int Id)
        : Request<GetDeveloperDetailsResponse, Developer>;
}
