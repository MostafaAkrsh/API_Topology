// <copyright file="Resistance.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using Newtonsoft.Json;

    internal class Resistance
    {
        [JsonProperty(PropertyName = "default")]
        public int Def { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }
    }
}
