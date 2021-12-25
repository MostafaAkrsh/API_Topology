using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_TOPOLOGY
{
    class M1
    {
        [JsonProperty(PropertyName = "default")]
        public double def { get; set; }
        public double min { get; set; }
        public double max { get; set; }
    }
}
