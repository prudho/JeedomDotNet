using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using JeedomDotNet.Tools;

namespace JeedomDotNet.Core
{
    public class HTTPQuery
    {
        private static ManualResetEvent allDone = new ManualResetEvent(false);

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
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_jeedom._url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";

                webRequest.BeginGetRequestStream(new AsyncCallback(GetRequestStreamCallback), webRequest);

                // Keep the main thread from continuing while the asynchronous operation completes.
                allDone.WaitOne();

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
            catch (Exception ex)
            {
                // Write output to Visual Studio
                Debug.WriteLine(ex.Message);

                _error = ex.Message;
            }

            return result;
        }

        private void GetRequestStreamCallback(IAsyncResult asynchronousResult)
        {
            HttpWebRequest request = (HttpWebRequest)asynchronousResult.AsyncState;

            // End the operation
            Stream postStream = request.EndGetRequestStream(asynchronousResult);

            // Convert the string into a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(_query);

            // Write to the request stream.
            postStream.Write(byteArray, 0, byteArray.Length);

            // Start the asynchronous operation to get the response
            request.BeginGetResponse(new AsyncCallback(GetResponseCallback), request);
        }

        private void GetResponseCallback(IAsyncResult asynchronousResult)
        {
            HttpWebRequest request = (HttpWebRequest)asynchronousResult.AsyncState;

            // End the operation
            using (HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(asynchronousResult))
            {
                using (StreamReader streamRead = new StreamReader(response.GetResponseStream()))
                {
                    _response = streamRead.ReadToEnd();
                }
            }

            allDone.Set();
        }
    }
}
