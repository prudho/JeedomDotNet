using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeedomDotNet.Entities
{
    public class Scenarios : List<Scenario>, IEntitiesCollection
    {
        private Jeedom _jee;

        private string _innerJson;
        private bool _loaded;
        private string _error;

        public bool Loaded { get { return _loaded; } }
        public string Error { get { return _error; } }
        public string InnerJson { get { return _innerJson; } }

        public Scenarios(Jeedom jee)
        {
            _jee = jee;

            Load();
        }

        public void Load()
        {
            this.Clear();

            _error = string.Empty;

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "scenario::all");

            bool result = rpc.Execute();

            if (result)
            {
                _innerJson = rpc.Response;

                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Scenario searchResult = JsonConvert.DeserializeObject<Scenario>(res.ToString());
                    Add(searchResult);
                }
            }
            else
            {
                _error = rpc.Error;
            }

            _loaded = result;
        }
    }
}
