using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class Objects : List<Object>, IEntitiesCollection
    {
        private Jeedom _jee;

        private string _innerJson;
        private bool _loaded;
        private string _error;

        public bool Loaded { get { return _loaded; } }
        public string Error { get { return _error; } }
        public string InnerJson { get { return _innerJson; } }

        public Objects(Jeedom jee)
        {
            _jee = jee;

            Load();
        }

        public void Load()
        {
            Clear();

            _error = string.Empty;

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "object::all");

            bool result = rpc.Execute();

            if (result)
            {
                _innerJson = rpc.Response;

                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Object searchResult = JsonConvert.DeserializeObject<Object>(res.ToString());

                    searchResult.BaseCollection = this;

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
