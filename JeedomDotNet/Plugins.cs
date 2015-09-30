using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
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

            string result = this._jee.RPCCommand("plugin::listPlugin");

            JObject googleSearch = JObject.Parse(result);

            IEnumerable<JToken> results = googleSearch["result"].Children();

            foreach (JToken res in results)
            {
                Plugin searchResult = JsonConvert.DeserializeObject<Plugin>(res.ToString());
                this.Add(searchResult);
            }
        }
    }
}
