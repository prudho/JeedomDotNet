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
    public class HTTPQuery
    {
        private Dictionary<string, object> _args;
        private string _query;
        private string _response;
        private Jeedom _jeedom;

        public event ResponseHandler OnResponse;
        public delegate void ResponseHandler(string message);

        public string Response { get { return this._response; } }

        public HTTPQuery(Jeedom jee, Dictionary<string, object> args)
        {
            this._response = string.Empty;

            this._args = args;
            this._jeedom = jee;

            // Formatting the POST request using HttpBuildQueryHelper
            // Thanks Roland Mai !!!
            _query = Tools.HttpBuildQueryHelper.FormatDictionary(args);
        }


        /// <summary>
        /// Send a POST request to the Jeedom controler
        /// </summary>
        /// <returns>True if query was sended and answered, false otherwise</returns>
        public bool Send()
        {
            bool result = false;

            this._response = string.Empty;

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(_query);

                // Certificate verification need to be disabled when we use a self-signed certificate
                // If not an exception occurs
                if (_jeedom.AllowSelfSignedCertificate)
                    ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(Tools.Misc.AcceptAllCertifications);

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_jeedom.URL);
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
                        OnResponse(_response);

                        result = true;
                    }
                }
            }
            catch (WebException webex)
            {
                // Write output to Visual Studio
                Debug.Write(webex.Message);
            }
            catch (Exception ex)
            {
                // Write output to Visual Studio
                Debug.Write(ex.Message);
            }

            return result;
        }
    }
}
