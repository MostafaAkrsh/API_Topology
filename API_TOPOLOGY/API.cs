// <copyright file="API.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    public static class API
    {
        private static readonly List<Topology> Topologies = new List<Topology>();

        // Method to read json file and put it into memory
        public static string ReadJSON(string file_path)
        {
            try
            {
                var json = File.ReadAllText(file_path); // read the file in the path
                Topology new_topology = (Topology)JsonConvert.DeserializeObject<Topology>(json); // convert it to topology calss

                Topologies.Add(new_topology); // add the topology into memory

                return "Read Operation Successed!"; // return this if the read operation successed
            }
            catch
            {
                return "Read Operation Failed!"; // return this if the read operation failed
            }
        }

        // Method to write topology into json file
        public static string WriteJSON(string topologyID)
        {
            try
            {
                Topology topology = Topologies.Find(x => x.Id == topologyID); // Find the topology by its id
                string json = JsonConvert.SerializeObject(topology, Formatting.Indented); // convert it to json file

                if (json != "null")
                {
                    string json_file_name = topologyID;
                    File.WriteAllText(topologyID + ".json", json); // write the json into 

                    return "Write Operation Successed!"; // return this if the write operation successed
                }
                else
                {
                    return "No Topology has this id in memory!";
                }
            }
            catch
            {
                return "Write Opeartion Failed!"; // return this if the write operation failed
            }
        }

        // method to return all topologies in memory
        public static List<Topology> QueryTopologies()
        {
            return Topologies; // return all topologies
        }

        // method to remove specific topology from memroy
        public static string DeleteTopology(string topologyID)
        {
            try
            {
                Topology topology = Topologies.Find(x => x.Id == topologyID);

                Topologies.Remove(topology);

                return "Delete Operation Successed"; // return this if the delete operation successed
            }
            catch
            {
                return "Delete Opeartion Failed!"; // return this if the delete operation failed
            }
        }

        // method to return components in specific topology
        public static List<Component> QueryDevices(string topologyID)
        {
            Topology topology = Topologies.Find(x => x.Id == topologyID); // find the topolgy has this id

            return topology.Components; // return the components
        }

        // method to know which devices are connected to a given netlist node a given topology.
        public static List<Component> QueryDevices(string topologyID, string netlistNodeID)
        {
            Topology topology = Topologies.Find(x => x.Id == topologyID); // find the topolgy has this id

            List<Component> components = topology.Components.FindAll(x => x.Netlist.ContainsValue(netlistNodeID)); // return the components has this netlist node

            return components;
        }
    }
}
