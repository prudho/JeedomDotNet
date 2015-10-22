using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
{
    public class EqLogics : List<object>
    {
        private Jeedom _jee;

        public EqLogics(Jeedom jee)
        {
            this._jee = jee;
        }

        public void Load()
        {
            this.Clear();

            string result = this._jee.RPCCommand("eqLogic::all");

            JObject googleSearch = JObject.Parse(result);

            IEnumerable<JToken> results = googleSearch["result"].Children();

            foreach (JToken res in results)
            {
                object searchResult = JsonConvert.DeserializeObject<object>(res.ToString());
                this.Add(searchResult);
            }
        }
    }
}
