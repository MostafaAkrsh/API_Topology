// <copyright file="Component.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using System.Collections.Generic;

    internal class Component
    {
        public string Type { get; set; }

        public string Id { get; set; }

        public Dictionary<string, string> Netlist { get; set; }

#nullable enable
        public Resistance? Resistance { get; set; }

        public M1? M { get; set; }
    }
}