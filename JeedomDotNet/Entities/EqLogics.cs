using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class EqLogics : List<EqLogic>
    {
        private Jeedom _jee;

        public EqLogics(Jeedom jee)
        {
            this._jee = jee;
        }

        public void Load()
        {
            this.Clear();

            Core.RPCCommand rpc = new Core.RPCCommand(this._jee, "eqLogic::all");

            if (rpc.Send())
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    EqLogic searchResult = JsonConvert.DeserializeObject<EqLogic>(res.ToString());
                    this.Add(searchResult);
                }
            }
        }
    }
}
