using System.Text.Json.Serialization;
using Zoo.Converter;

namespace Zoo.Models
{
    public class Zoo
    {
        [JsonConverter(typeof(ObjectConverter<List<Animal>>))]
        public List<Animal>? Animals { get; set; }
        public string? ZooKeeper { get; set; }
    }
}
