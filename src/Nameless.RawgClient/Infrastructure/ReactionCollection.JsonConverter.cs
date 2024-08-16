using Nameless.RawgClient.Objects;

namespace Nameless.RawgClient.Infrastructure {
    /// <summary>
    /// An implementation of <see cref="JsonConverter"/> for <see cref="ReactionCollection"/>.
    /// </summary>
    public sealed class ReactionCollectionJsonConverter : JsonConverter<ReactionCollection> {
        /// <inheritdoc />
        public override ReactionCollection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType != JsonTokenType.StartObject) {
                throw new JsonException("Invalid start object token.");
            }

            var dictionary = new Dictionary<string, int>();
            var type = string.Empty;
            var done = false;
            while (!done && reader.Read()) {
                // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
                switch (reader.TokenType) {
                    case JsonTokenType.PropertyName:
                        // Get Resolution
                        type = reader.GetString() ?? string.Empty;
                        break;

                    case JsonTokenType.String:
                        // Get Url
                        dictionary[type] = reader.GetInt32();
                        break;

                    case JsonTokenType.EndObject:
                        done = true;
                        break;
                }
            }

            var items = dictionary.Select(kvp => new Reaction {
                                      Type = kvp.Key,
                                      Value = kvp.Value
                                  })
                                  .ToList();

            return new ReactionCollection(items);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, ReactionCollection value, JsonSerializerOptions options) {
            writer.WriteStartObject();
            foreach (var item in value) {
                writer.WritePropertyName(item.Type);
                writer.WriteNumberValue(item.Value);
            }

            writer.WriteEndObject();
        }
    }
}
