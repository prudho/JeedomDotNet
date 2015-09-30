using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
{
    public class Message
    {
        public string id { get; }
        public string date { get; }
        public string logicalId { get; }
        public string plugin { get; }
        public string message { get; }
        public string action { get; }
    }
}
