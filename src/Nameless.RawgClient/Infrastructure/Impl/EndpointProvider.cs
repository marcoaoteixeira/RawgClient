namespace Nameless.RawgClient.Infrastructure.Impl {
    /// <summary>
    /// Implementation of <see cref="IEndpointProvider"/>
    /// </summary>
    public class EndpointProvider : IEndpointProvider {
        /// <inheritdoc />
        public string GetEndpoint(Request request)
            => request switch {
                GetCreatorRolesRequest => Endpoints.CreatorRoles.GetCreatorRoles,

                _ => throw new InvalidOperationException("Missing case for request.")
            };
    }
}
