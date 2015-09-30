using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
{
    public class Index
    {
        public string __invalid_name__0 { get; set; }
    }

    public class File
    {
        public string __invalid_name__0 { get; set; }
    }

    public class Include
    {
        public File file { get; set; }
        public string type { get; set; }
    }

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
        public Index index { get; set; }
        public string display { get; set; }
        public string mobile { get; set; }
        public object allowRemote { get; set; }
        public int nodejs { get; set; }
        public Include include { get; set; }
    }
}
