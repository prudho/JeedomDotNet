using Newtonsoft.Json;

namespace JeedomDotNet.Entities
{
    public class EqLogic
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "isVisible")]
        [JsonConverter(typeof(Tools.BoolConverter))]
        public bool Visible { get; set; }

        [JsonProperty(PropertyName = "isEnable")]
        [JsonConverter(typeof(Tools.BoolConverter))]
        public bool Enabled { get; set; }
    }
}
