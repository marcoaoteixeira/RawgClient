using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Infrastructure {
    public sealed class OrderingJsonConverter : JsonConverter<Ordering> {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, Ordering value, JsonSerializer serializer)
            => writer.WriteValue((string)value);

        /// <inheritdoc />
        public override Ordering ReadJson(JsonReader reader, Type objectType, Ordering existingValue, bool hasExistingValue, JsonSerializer serializer)
            => (Ordering)(reader.Value as string);
    }
}
