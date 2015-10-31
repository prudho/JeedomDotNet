using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class Commands : List<Command>, IEntitiesCollection
    {
        private Jeedom _jee;
        private JeedomEntities _entities;

        private string _innerJson;
        private bool _loaded;
        private string _error;

        public bool Loaded { get { return _loaded; } }
        public string Error { get { return _error; } }
        public string InnerJson { get { return this._innerJson; } }

        public Commands(Jeedom jee, JeedomEntities entities)
        {
            _jee = jee;
            _entities = entities;

            Load();
        }

        public void Load()
        {
            Clear();

            _error = string.Empty;

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "cmd::all");

            bool result = rpc.Execute();

            if (result)
            {
                _innerJson = rpc.Response;

                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    Command searchResult = JsonConvert.DeserializeObject<Command>(res.ToString());

                    searchResult.BaseCollection = _entities.EqLogics;

                    Add(searchResult);
                }
            }
            else
            {
                _error = rpc.Error;
            }

            _loaded = result;
        }

        public Command Get(int id)
        {
            Load();

            return Find(x => x.ID == id);
        }
    }
}
