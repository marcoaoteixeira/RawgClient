using Nameless.RawgClient.Common;

namespace Nameless.RawgClient {
    /// <summary>
    /// Defines the method responsible for querying RAWG API games database.
    /// </summary>
    public interface IRawg {
        /// <summary>
        /// Executes a query against RAWG API for given request.
        /// </summary>
        /// <typeparam name="TResponse">Type of the response.</typeparam>
        /// <typeparam name="TResult">Type of the response content.</typeparam>
        /// <param name="request">The request object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A response object.</returns>
        Task<TResponse> QueryAsync<TResponse, TResult>(Request<TResponse, TResult> request, CancellationToken cancellationToken)
            where TResponse : Response<TResult>, new()
            where TResult : class;
    }
}
