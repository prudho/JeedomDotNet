using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
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

            string result = this._jee.RPCCommand("object::all");

            JObject googleSearch = JObject.Parse(result);

            IEnumerable<JToken> results = googleSearch["result"].Children();

            foreach (JToken res in results)
            {
                Object searchResult = JsonConvert.DeserializeObject<Object>(res.ToString());
                this.Add(searchResult);
            }
        }
    }
}
