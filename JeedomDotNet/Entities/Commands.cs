using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class Commands : List<Command>
    {
        private Jeedom _jee;

        public Commands(Jeedom jee)
        {
            this._jee = jee;
        }

        public void Load()
        {
            this.Clear();

            Core.RPCCommand rpc = new Core.RPCCommand(this._jee, "cmd::all");

            if (rpc.Send())
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Command searchResult = JsonConvert.DeserializeObject<Command>(res.ToString());
                    this.Add(searchResult);
                }
            }
        }

        public Command Get(int id)
        {
            this.Load();

            return this.Find(x => x.id == id.ToString());
        }
    }
}
