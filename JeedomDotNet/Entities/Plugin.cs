using Newtonsoft.Json;

namespace JeedomDotNet.Entities
{
    public class Plugin
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "licence")]
        public string Licence { get; set; }

        [JsonProperty(PropertyName = "installation")]
        public string Installation { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "require")]
        public string Require { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "filepath")]
        public string Filepath { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }

        public object allowRemote { get; set; }

        public int nodejs { get; set; }
    }
}
