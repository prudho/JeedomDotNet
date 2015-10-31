using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class Messages : List<Message>, IEntitiesCollection
    {
        private Jeedom _jee;

        private bool _loaded;
        private string _error;

        public bool Loaded { get { return _loaded; } }
        public string Error { get { return _error; } }

        public Messages(Jeedom jee)
        {
            _jee = jee;

            Load();
        }

        public void Load()
        {
            Clear();

            _error = string.Empty;

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "message::all");

            bool result = rpc.Execute();

            if (result)
            {
                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Message searchResult = JsonConvert.DeserializeObject<Message>(res.ToString());
                    Add(searchResult);
                }
            }
            else
            {
                _error = rpc.Error;
            }

            _loaded = result;
        }

        public bool Empty()
        {

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "message::removeAll");

            if (rpc.Execute())
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
