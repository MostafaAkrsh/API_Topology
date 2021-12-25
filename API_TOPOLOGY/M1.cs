// <copyright file="M1.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using Newtonsoft.Json;

    internal class M1
    {
        [JsonProperty(PropertyName = "default")]
        public double Def { get; set; }

        public double Min { get; set; }

        public double Max { get; set; }
    }
}
