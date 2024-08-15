namespace Nameless.RawgClient.Common {
    /// <summary>
    /// Defines a base generic request object.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <typeparam name="TResult">The type of the result inside the response.</typeparam>
    public abstract record Request<TResponse, TResult> : Request
        where TResponse : Response<TResult>, new()
        where TResult : class;
}
