using System.Text.Json.Serialization;
using System.Text.Json;

namespace QrCode.Dto
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss"));
        }
    }

    public class CreatePengunjungDto
    {
        public string Nama { get; set; } = null!;
        public string NoHP { get; set; } = null!;
        public string Kantor { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
