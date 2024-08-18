using System.Globalization;

namespace Nameless.RawgClient.Json.Converters {
    /* **************************************** WHY?? **************************************** */
    /* The motivation behind this was that <see cref="JsonSerializer"/> do not "play along"    */
    /* with <c>null</c> values (in JSON) to non-nullable built-in types. What it means, if     */
    /* your JSON has a property that is an <see cref="int"/> value (as an example) but its     */
    /* current value is <c>null</c>, <see cref="JsonSerializer"/> will fail with an exception. */
    /* IMHO, I understand this (maybe) should be the expected behavior, and you should define  */
    /* your properties, inside your type, as <see cref="Nullable"/> but, I don't like the      */
    /* idea of having N number of nullable properties because of this. What I expected was     */
    /* that <see cref="JsonSerializer"/> would ignore this <c>null</c> behavior and initialize */
    /* the property with its default value.                                                    */
    /* So, need to implement to each built-in type that your want this behavior...fuck...      */
    /* **************************************** WHY?? **************************************** */
    
    /// <summary>
    /// Implementation to deal with <c>null</c> values in JSON for built-in <see cref="int"/>.
    /// </summary>
    public sealed class IntJsonConverter : JsonConverter<int> {
        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert)
            => typeToConvert == typeof(int);

        /// <inheritdoc />
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.TokenType switch {
                JsonTokenType.String when int.TryParse(reader.GetString(), out var result) => result,
                JsonTokenType.Number => reader.GetInt32(),
                _ => default
            };

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }

    /// <summary>
    /// Implementation to deal with <c>null</c> values in JSON for built-in <see cref="double"/>.
    /// </summary>
    public sealed class DoubleJsonConverter : JsonConverter<double> {
        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert)
            => typeToConvert == typeof(double);

        /// <inheritdoc />
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.TokenType switch {
                JsonTokenType.String when double.TryParse(s: reader.GetString(),
                                                          provider: CultureInfo.InvariantCulture,
                                                          style: NumberStyles.Any,
                                                          result: out var result) => result,
                JsonTokenType.Number => reader.GetDouble(),
                _ => default
            };

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }

    /// <summary>
    /// Implementation to deal with <c>null</c> values in JSON for built-in <see cref="DateTimeOffset"/>.
    /// </summary>
    public sealed class DateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset> {
        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert)
            => typeToConvert == typeof(DateTimeOffset);

        /// <inheritdoc />
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.TokenType switch {
                JsonTokenType.String when DateTimeOffset.TryParse(input: reader.GetString(),
                                                                  formatProvider: CultureInfo.InvariantCulture,
                                                                  styles: DateTimeStyles.AdjustToUniversal,
                                                                  result: out var result) => result,
                _ => default
            };

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
            => writer.WriteStringValue(value);
    }
}
