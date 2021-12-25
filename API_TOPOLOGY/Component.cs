using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_TOPOLOGY
{
    class Component
    {
        public string type { get; set; }
        public string id { get; set; }
        public Dictionary<string,string> netlist { get; set; }

        [JsonProperty(PropertyName = "m(1)")]
        public M1 m1 { get; set; }
        public Resistance resistance { get; set; }
    }
}
