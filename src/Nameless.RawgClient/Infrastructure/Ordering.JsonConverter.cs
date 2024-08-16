namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// JSON converter implementation to deal with type <see cref="Ordering"/>
    /// </summary>
    public sealed class OrderingJsonConverter : JsonConverter<Ordering> {
        /// <inheritdoc />
        public override Ordering Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType != JsonTokenType.String) {
                return new Ordering();
            }

            return (Ordering)(reader.GetString() ?? string.Empty);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Ordering value, JsonSerializerOptions options)
            => writer.WriteStringValue((string)value);
    }
}
