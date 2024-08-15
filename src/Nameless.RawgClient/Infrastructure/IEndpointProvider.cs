using Nameless.RawgClient.Common;

namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// Contract to provide means to retrieve an endpoint based on its request object.
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
