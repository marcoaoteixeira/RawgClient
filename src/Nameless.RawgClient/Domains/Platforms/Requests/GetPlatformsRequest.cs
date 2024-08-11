namespace Nameless.RawgClient.Domains.Platforms.Requests {
    /// <summary>
    /// Represents a request object for a list of platform.
    /// </summary>
    public sealed record GetPlatformsRequest
        : Request<GetPlatformsResponse, Platform>;
}
