﻿using Newtonsoft.Json;
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
        public int def { get; set; }
        public int min { get; set; }
        public int max { get; set; }
    }
}
