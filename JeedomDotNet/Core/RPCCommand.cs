using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace JeedomDotNet.Core
{
    public class RPCCommand
    {
        private Dictionary<string, object> _vars;
        private Dictionary<string, object> _RPCcommand;
        private string _method;
        private string _response;
        private string _error;
        private Jeedom _jeedom;

        public string Error { get { return _error; } }
        public string Response { get { return _response; } }

        public RPCCommand(Jeedom jee, string method)
        {
            _method = method;
            _vars = new Dictionary<string, object> ();

            Init(jee);
        }

        public RPCCommand(Jeedom jee, string method, Dictionary<string, object> vars)
        {
            _method = method;
            _vars = vars;
            
            Init(jee);
        }

        private void Init(Jeedom jee)
        {
            _jeedom = jee;
            _response = string.Empty;
            _error = string.Empty;

            // Our RPC command "object"
            Dictionary<string, object> request = new Dictionary<string, object>()
            {
                { "jsonrpc", "2.0" },
                { "id", new Random().Next(1,9999) },
                { "method", _method },
                { "params", _vars }
            };

            // We inject the API key in the command parameters
            Dictionary<string, object> par = (Dictionary<string, object>)request["params"];
            par.Add("apikey", _jeedom._api_key);

            // Our RPC command is encapsulated by JSON...
            _RPCcommand = new Dictionary<string, object>()
            {
                { "request", JsonConvert.SerializeObject(request) }
            };
        }

        public bool Execute()
        {
            // And sent by POST request to the Jeedom controler
            HTTPQuery query = new HTTPQuery(_jeedom, _RPCcommand);

            bool result = query.Execute();

            if (result)
                _response = query.Response;
            else
                _error = query.Error;

            return result;
        }
    }
}
