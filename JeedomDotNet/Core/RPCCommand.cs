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
        private Jeedom _jeedom;

        public event ResponseHandler OnResponse;
        public delegate void ResponseHandler(string message);

        public string Response { get { return this._response; } }

        public RPCCommand(Jeedom jee, string method)
        {
            this._method = method;
            this._vars = new Dictionary<string, object> ();

            this.Init(jee);
        }

        public RPCCommand(Jeedom jee, string method, Dictionary<string, object> vars)
        {
            this._method = method;
            this._vars = vars;
            
            this.Init(jee);
        }

        private void Init(Jeedom jee)
        {
            this._jeedom = jee;
            this._response = string.Empty;

            // Our RPC command "object"
            Dictionary<string, object> request = new Dictionary<string, object>()
            {
                { "jsonrpc", "2.0" },
                { "id", new Random().Next(1,9999) },
                { "method", this._method },
                { "params", this._vars }
            };

            // We inject the API key in the command parameters
            Dictionary<string, object> par = (Dictionary<string, object>)request["params"];
            par.Add("apikey", this._jeedom.API_Key);

            // Our RPC command is encapsulated by JSON...
            _RPCcommand = new Dictionary<string, object>()
            {
                { "request", JsonConvert.SerializeObject(request) }
            };
        }

        public bool Send()
        {
            // And send by POST request to the Jeedom controler
            Core.HTTPQuery query = new Core.HTTPQuery(this._jeedom, _RPCcommand);

            bool result = query.Send();

            if (result)
                this._response = query.Response;

            return result;
        }
    }
}
