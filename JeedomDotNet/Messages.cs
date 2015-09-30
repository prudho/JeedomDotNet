using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JeedomDotNet
{
    public class Messages : List<Message>
    {
        private Jeedom _jee;

        public Messages(Jeedom jee)
        {
            this._jee = jee;
        }

        public void Load()
        {
            this.Clear();

            string result = this._jee.RPCCommand("message::all");

            JObject googleSearch = JObject.Parse(result);

            IEnumerable<JToken> results = googleSearch["result"].Children();

            foreach (JToken res in results)
            {
                Message searchResult = JsonConvert.DeserializeObject<Message>(res.ToString());
                this.Add(searchResult);
            }
        }

        public bool Empty()
        {
            string result = this._jee.RPCCommand("message::removeAll");

            JObject googleSearch = JObject.Parse(result);

            IEnumerable<JToken> results = googleSearch["result"];

            return (results.ToString() == "ok");
        }
    }
}
