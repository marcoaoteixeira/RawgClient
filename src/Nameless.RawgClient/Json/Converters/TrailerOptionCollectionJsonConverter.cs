using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Json.Converters {
    /// <summary>
    /// An implementation of <see cref="JsonConverter"/> for <see cref="TrailerOptionCollection"/>.
    /// </summary>
    public sealed class TrailerOptionCollectionJsonConverter : JsonConverter<TrailerOptionCollection> {
        /// <inheritdoc />
        public override TrailerOptionCollection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType != JsonTokenType.StartObject) {
                throw new JsonException("Invalid start object token.");
            }

            var dictionary = new Dictionary<string, string>();
            var resolution = string.Empty;
            var done = false;
            while (!done && reader.Read()) {
                // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
                switch (reader.TokenType) {
                    case JsonTokenType.PropertyName:
                        // Get Resolution
                        resolution = reader.GetString() ?? string.Empty;
                        break;

                    case JsonTokenType.String:
                        // Get Url
                        dictionary[resolution] = reader.GetString() ?? string.Empty;
                        break;

                    case JsonTokenType.EndObject:
                        done = true;
                        break;
                }
            }

            var items = dictionary.Select(kvp => new TrailerOption {
                                      Resolution = kvp.Key,
                                      Url = kvp.Value
                                  })
                                  .ToList();

            return new TrailerOptionCollection(items);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, TrailerOptionCollection value, JsonSerializerOptions options) {
            writer.WriteStartObject();
            foreach (var item in value) {
                writer.WritePropertyName(item.Resolution);
                writer.WriteStringValue(item.Url);
            }

            writer.WriteEndObject();
        }
    }
}
