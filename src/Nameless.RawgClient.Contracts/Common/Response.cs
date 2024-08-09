#if NET6_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif

namespace Nameless.RawgClient.Contracts.Common {
    public abstract record Response<TResult>
        where TResult : class {
#if NET6_0_OR_GREATER
        [MemberNotNullWhen(returnValue: false, nameof(Error))]
        [MemberNotNullWhen(returnValue: true, nameof(Result))]
#endif
        public bool Succeeded => Error is null;

        public TResult? Result { get; init; }

        public string? Error { get; init; }
    }
}
