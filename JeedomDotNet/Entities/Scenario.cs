using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JeedomDotNet.Entities
{
    public enum Type
    {
        Simple,
        Expert
    }

    public enum Mode
    {

        Provoke,
        All
    }

    public class Scenario
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "isVisible")]
        [JsonConverter(typeof(Tools.BoolConverter))]
        public bool IsVisible { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        [JsonConverter(typeof(Tools.BoolConverter))]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "type")]
        public Type Type { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public Mode Mode { get; set; }

        [JsonProperty(PropertyName = "object_id")]
        public int? ObjectID { get; set; }

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
