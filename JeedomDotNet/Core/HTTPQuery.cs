using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using JeedomDotNet.Tools;

namespace JeedomDotNet.Core
{
    public class HTTPQuery
    {
        private Dictionary<string, object> _args;
        private string _query;
        private string _response;
        private string _error;
        private Jeedom _jeedom;

        public string Error { get { return _error; } }
        public string Response { get { return _response; } }

        public HTTPQuery(Jeedom jee, Dictionary<string, object> args)
        {
            _args = args;
            _jeedom = jee;

            // Formatting the POST request using HttpBuildQueryHelper
            // Thanks Roland Mai !!!
            _query = HttpBuildQueryHelper.FormatDictionary(args);
        }


        /// <summary>
        /// Send a POST request to the Jeedom controler
        /// </summary>
        /// <returns>True if query was sended and answered, false otherwise</returns>
        public bool Execute()
        {
            bool result = false;

            _response = string.Empty;
            _error = string.Empty;

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(_query);

                // Certificate verification need to be disabled when we use a self-signed certificate
                // If not an exception occurs
                if (_jeedom._allowSelfSignedCert)
                    ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(Misc.AcceptAllCertifications);

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_jeedom._url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;

                // Sending our POST request
                using (Stream webpageStream = webRequest.GetRequestStream())
                {
                    webpageStream.Write(byteArray, 0, byteArray.Length);
                }

                // Reading the response
                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        _response = reader.ReadToEnd();

                        _jeedom.Log(_response);

                        JObject googleSearch = JObject.Parse(_response);

                        IEnumerable<JToken> results = googleSearch["error"];

                        if (results != null)
                        {
                            _error = googleSearch["error"]["message"].ToString();
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Write output to Visual Studio
                Debug.Write(ex.Message);

                _error = ex.Message;
            }

            return result;
        }
    }
}
