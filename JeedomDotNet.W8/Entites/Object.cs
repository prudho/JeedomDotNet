using Newtonsoft.Json;
using JeedomDotNet;

namespace JeedomDotNet.Entities
{
    public class Object
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "father_id")]
        public int? Parent_ID { get; set; }

        [JsonProperty(PropertyName = "isVisible")]
        [JsonConverter(typeof(Tools.BoolConverter))]
        public bool Visible { get; set; }

        public Object Parent { get { return getParent(); } }

        internal Objects BaseCollection;

        private Object getParent()
        {
            if (Parent_ID != null)
            {
                return BaseCollection.Find(x => x.ID == Parent_ID);
            }
            else
            {
                return null;
            }
        }
    }
}
