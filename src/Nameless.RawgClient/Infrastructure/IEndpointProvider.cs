namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// Provides methods to retrieve an endpoint based in a request object.
    /// </summary>
    public interface IEndpointProvider {
        /// <summary>
        /// Retrieves the endpoint associated with the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>A <see cref="string"/> representing the endpoint for the request.</returns>
        string GetEndpoint(Request request);
    }
}
