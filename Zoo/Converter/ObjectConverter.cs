using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zoo.Converter
{
    public class ObjectConverter<T> : JsonConverter<T> where T : class
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return true;
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var enumerable = (value as IEnumerable);
            if (value is not string && enumerable != null)
            {
                writer.WriteStartArray();
                foreach (var idpguid in enumerable)
                {
                    JsonSerializer.Serialize<object>(writer, idpguid, options);
                }
                writer.WriteEndArray();
            }
            else
            {
                JsonSerializer.Serialize<object>(writer, value, options);
            }
        }
    }
}
