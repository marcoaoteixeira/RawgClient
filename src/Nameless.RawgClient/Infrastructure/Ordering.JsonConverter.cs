namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// JSON converter implementation to deal with type <see cref="Ordering"/>
    /// </summary>
    public sealed class OrderingJsonConverter : JsonConverter<Ordering> {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, Ordering value, JsonSerializer serializer)
            => writer.WriteValue((string)value);

        /// <inheritdoc />
        public override Ordering ReadJson(JsonReader reader, Type objectType, Ordering existingValue, bool hasExistingValue, JsonSerializer serializer)
            => (Ordering)(reader.Value as string);
    }
}
