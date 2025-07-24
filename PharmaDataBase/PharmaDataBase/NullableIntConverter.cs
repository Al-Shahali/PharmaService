

using System.Text.Json;
using System.Text.Json.Serialization;

namespace PharmaDataBase
{
    public class NullableIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                if (reader.TokenType == JsonTokenType.Number)
                    return reader.GetInt32();
                if (reader.TokenType == JsonTokenType.String)
                {
                    var str = reader.GetString();
                    if (int.TryParse(str, out int value))
                        return value;
                }
            }
            catch { }

            return null; // Or throw, depending on your strategy
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }

}
