// <copyright file="Resistance.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using Newtonsoft.Json;

    public class Resistance
    {
        [JsonProperty(PropertyName = "default")]
        public double Def { get; set; }

        [JsonProperty(PropertyName = "min")]
        public double Min { get; set; }

        [JsonProperty(PropertyName = "max")]
        public double Max { get; set; }
    }
}
