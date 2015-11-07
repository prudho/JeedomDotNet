using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JeedomDotNet.Entities
{
    public class EqLogics : List<EqLogic>, IEntitiesCollection
    {
        private Jeedom _jee;
        private JeedomEntities _entities;

        private bool _loaded;
        private string _error;
        private string _innerJson;

        public bool Loaded { get { return _loaded; } }
        public string Error { get { return _error; } }
        public string InnerJson { get { return this._innerJson; } }

        public EqLogics(Jeedom jee, JeedomEntities entities)
        {
            _jee = jee;
            _entities = entities;

            Load();
        }

        public void Load()
        {
            Clear();

            _error = string.Empty;

            Core.RPCCommand rpc = new Core.RPCCommand(_jee, "eqLogic::all");

            bool result = rpc.Execute();

            if (result)
            {
                _innerJson = rpc.Response;

                JObject googleSearch = JObject.Parse(rpc.Response);

                IEnumerable<JToken> results = googleSearch["result"].Children();

                foreach (JToken res in results)
                {
                    EqLogic searchResult = JsonConvert.DeserializeObject<EqLogic>(res.ToString());

                    searchResult.BaseCollection = _entities.Objects;

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
