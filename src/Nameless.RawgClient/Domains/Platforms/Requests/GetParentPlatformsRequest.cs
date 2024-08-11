namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Represents a request object for a list of parent platforms.
    /// </summary>
    public sealed record GetParentPlatformsRequest
        : Request<GetParentPlatformsResponse, ParentPlatform>;
}
