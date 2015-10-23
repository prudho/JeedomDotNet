using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace JeedomDotNet.Entities
{
    public class Plugins : List<Plugin>
    {
        private Jeedom _jee;

        public Plugins(Jeedom jee)
        {
            this._jee = jee;
        }

        public void Load()
        {
            this.Clear();

            Core.RPCCommand rpc = new Core.RPCCommand(this._jee, "plugin::listPlugin");

            if (rpc.Send())
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Plugin searchResult = JsonConvert.DeserializeObject<Plugin>(res.ToString());
                    this.Add(searchResult);
                }
            }
        }
    }
}
