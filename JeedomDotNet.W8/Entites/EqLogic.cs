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

        [JsonProperty(PropertyName = "eqType_name")]
        public string EqTypeName { get; set; }

        [JsonProperty(PropertyName = "object_id")]
        public int? ObjectID { get; set; }

        [JsonProperty(PropertyName = "logicalId")]
        public string LogicalID { get; set; }

        public Object Parent { get { return getParent(); } }

        internal Objects BaseCollection;

        private Object getParent()
        {
            if (this.ObjectID != null)
            {
                return BaseCollection.Find(x => x.ID == ObjectID);
            }
            else
            {
                return null;
            }
        }
    }
}
