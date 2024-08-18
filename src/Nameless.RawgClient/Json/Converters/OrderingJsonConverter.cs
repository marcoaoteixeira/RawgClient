using Nameless.RawgClient.Infrastructure;

namespace Nameless.RawgClient.Json.Converters {
    /// <summary>
    /// JSON converter implementation to deal with type <see cref="Ordering"/>
    /// </summary>
    public sealed class OrderingJsonConverter : JsonConverter<Ordering> {
        /// <inheritdoc />
        public override Ordering Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            var empty = new Ordering();

            if (reader.TokenType != JsonTokenType.String) {
                return empty;
            }

            return Ordering.TryParse(reader.GetString(), out var ordering)
                ? ordering
                : empty;
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Ordering value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.GetStringValue());
    }
}
