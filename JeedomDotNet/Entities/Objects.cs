using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class Objects : List<Object>
    {
        private Jeedom _jee;

        public Objects(Jeedom jee)
        {
            this._jee = jee;
        }

        public void Load()
        {
            this.Clear();

            Core.RPCCommand rpc = new Core.RPCCommand(this._jee, "object::all");

            if (rpc.Send())
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Object searchResult = JsonConvert.DeserializeObject<Object>(res.ToString());
                    this.Add(searchResult);
                }
            }
        }
    }
}
