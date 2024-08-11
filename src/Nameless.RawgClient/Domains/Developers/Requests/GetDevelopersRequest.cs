namespace Nameless.RawgClient.Domains.Developers.Requests {
    /// <summary>
    /// Represents a request object for a list of developer.
    /// </summary>
    public sealed record GetDevelopersRequest
        : Request<GetDevelopersResponse, Developer>;
}
