using System.Text.Json.Nodes;

namespace Nameless.RawgClient {
    internal static class JsonNodeExtension {
        internal static int GetIntValue(this JsonNode? self)
            => self is not null && self.AsValue()
                                       .TryGetValue<int>(out var value)
                ? value
                : 0;

        internal static string? GetStringValue(this JsonNode? self)
            => self is not null && self.AsValue()
                                       .TryGetValue<string>(out var value)
                ? value
                : null;

        internal static TValue DeserializeWithFallback<TValue>(this JsonNode? self, Func<TValue> fallback)
            => self is not null
                ? self.Deserialize<TValue>() ?? fallback()
                : fallback();
    }
}
