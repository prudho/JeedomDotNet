using Newtonsoft.Json;

namespace JeedomDotNet.Entities
{
    public class Plugin
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string licence { get; set; }
        public string installation { get; set; }
        public string author { get; set; }
        public string require { get; set; }
        public string version { get; set; }
        public string category { get; set; }
        public string filepath { get; set; }
        public string icon { get; set; }
        public string display { get; set; }
        public string mobile { get; set; }
        public object allowRemote { get; set; }
        public int nodejs { get; set; }
    }
}
