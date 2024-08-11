namespace Nameless.RawgClient {
    internal static class Prevent {
        internal static T Null<T>([NotNull] T? paramValue, string paramName)
            where T : class
            => paramValue ?? throw new ArgumentNullException(paramName);

        internal static string NullOrWhiteSpace(string paramValue, string paramName)
            => string.IsNullOrWhiteSpace(paramValue)
                ? throw new ArgumentException("Parameter cannot be null, empty or white spaces.", paramName)
                : paramValue;

        internal static int LowerThan(int paramValue, int value, string paramName)
            => paramValue < value
                ? throw new ArgumentOutOfRangeException(paramName, paramValue, $"Parameter cannot be lower than {value}")
                : paramValue;
    }
}
