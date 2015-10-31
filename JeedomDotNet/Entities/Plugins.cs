using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace JeedomDotNet.Entities
{
    public class Plugins : List<Plugin>, IEntitiesCollection
    {
        private Jeedom _jee;

        private string _innerJson;
        private bool _loaded;
        private string _error;

        public bool Loaded { get { return _loaded; } }
        public string Error { get { return _error; } }
        public string InnerJson { get { return _innerJson; } }

        public Plugins(Jeedom jee)
        {
            _jee = jee;

            Load();
        }

        public void Load()
        {
            this.Clear();

            _error = string.Empty;

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "plugin::listPlugin");

            bool result = rpc.Execute();

            if (result)
            {
                _innerJson = rpc.Response;

                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Plugin searchResult = JsonConvert.DeserializeObject<Plugin>(res.ToString());
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
