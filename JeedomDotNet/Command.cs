using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeedomDotNet
{
    public class Configuration
    {
        public string day { get; set; }
        public string data { get; set; }
        public string loadavg1mnvertinfa { get; set; }
        public string loadavg1mnorangede { get; set; }
        public string loadavg1mnorangea { get; set; }
        public string loadavg1mnrougesupa { get; set; }
        public string loadavg5mnvertinfa { get; set; }
        public string loadavg5mnorangede { get; set; }
        public string loadavg5mnorangea { get; set; }
        public string loadavg5mnrougesupa { get; set; }
        public string loadavg15mnvertinfa { get; set; }
        public string loadavg15mnorangede { get; set; }
        public string loadavg15mnorangea { get; set; }
        public string loadavg15mnrougesupa { get; set; }
        public string Mempourcrougeinfa { get; set; }
        public string Mempourcorangede { get; set; }
        public string Mempourcorangea { get; set; }
        public string Mempourcvertsupa { get; set; }
        public string hddpourcusedvertinfa { get; set; }
        public string hddpourcusedorangede { get; set; }
        public string hddpourcusedorangea { get; set; }
        public string hddpourcusedrougesupa { get; set; }
        public string cpu_tempvertinfa { get; set; }
        public string cpu_temporangede { get; set; }
        public string cpu_temporangea { get; set; }
        public string cpu_temprougesupa { get; set; }
        public string perso2 { get; set; }
        public string perso2_unite { get; set; }
        public string perso1 { get; set; }
        public string perso1_unite { get; set; }
        public string instanceId { get; set; }
        public string @class { get; set; }
        public string value { get; set; }
        public string calculValueOffset { get; set; }
        public string returnStateValue { get; set; }
        public string returnStateTime { get; set; }
        public string minValue { get; set; }
        public string maxValue { get; set; }
    }

    public class Template
    {
        public string dashboard { get; set; }
        public string mobile { get; set; }
    }

    public class Display
    {
        public string icon { get; set; }
        public string invertBinary { get; set; }
        public string graphType { get; set; }
        public string graphStep { get; set; }
        public string graphDerive { get; set; }
    }

    public class Command
    {
        public string id { get; set; }
        public string logicalId { get; set; }
        public string eqType { get; set; }
        public string name { get; set; }
        public string order { get; set; }
        public string type { get; set; }
        public string subType { get; set; }
        public string eqLogic_id { get; set; }
        public string isHistorized { get; set; }
        public string unite { get; set; }
        public object cache { get; set; }
        public string eventOnly { get; set; }
        public Configuration configuration { get; set; }
        public Template template { get; set; }
        public Display display { get; set; }
        public string value { get; set; }
        public string isVisible { get; set; }
    }
}
