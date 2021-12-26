// <copyright file="Component.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Component
    {

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "netlist")]
        public Dictionary<string, string> Netlist { get; set; }

#nullable enable
        [JsonProperty(PropertyName = "resistance")]
        public Resistance? Resistance { get; set; }

        [JsonProperty(PropertyName = "m")]
        public M1? M { get; set; }
    }
}