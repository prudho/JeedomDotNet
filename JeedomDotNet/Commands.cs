using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
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

            string result = this._jee.RPCCommand("cmd::all");

            JObject googleSearch = JObject.Parse(result);

            IEnumerable<JToken> results = googleSearch["result"].Children();

            foreach (JToken res in results)
            {
                Command searchResult = JsonConvert.DeserializeObject<Command>(res.ToString());
                this.Add(searchResult);
            }
        }

        public Command Get(int id)
        {
            this.Load();

            return this.Find(x => x.id == id.ToString());
        }
    }
}
