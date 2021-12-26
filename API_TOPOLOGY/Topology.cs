// <copyright file="Topology.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Topology
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "components")]
        public List<Component> Components { get; set; }
    }
}
