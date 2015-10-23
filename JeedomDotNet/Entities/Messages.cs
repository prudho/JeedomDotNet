using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
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

            Core.RPCCommand rpc = new Core.RPCCommand(this._jee, "message::all");

            if (rpc.Send())
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Message searchResult = JsonConvert.DeserializeObject<Message>(res.ToString());
                    this.Add(searchResult);
                }
            }
        }

        public bool Empty()
        {

            Core.RPCCommand rpc = new Core.RPCCommand(this._jee, "message::removeAll");

            if (rpc.Send())
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"];

                return (results.ToString() == "ok");
            }
            else
            {
                return false;
            }
        }
    }
}
