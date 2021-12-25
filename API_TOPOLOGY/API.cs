using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_TOPOLOGY
{
    static class API
    {
        // private list stores the topologies in memory
        private static List<Topology> _topologies = new List<Topology>();

        // Method to read json file and put it into memory
        public static string ReadJSON(string file_path)
        {
            try
            {
                var json = File.ReadAllText(file_path); //read the file in the path
                Topology new_topology = (Topology)JsonConvert.DeserializeObject<Topology>(json); // convert it to topology calss

                _topologies.Add(new_topology); // add the topology into memory

                return "Read Operation Successed!"; // return this if the read operation successed
            }
            catch
            {
                return "Read Opeartion Failed!"; // return this if the read operation failed
            }
        }

        // Method to write topology into json file
        public static string WriteJSON(string topologyID)
        {
            try
            {
            Topology topology = _topologies.Find(x => x.id == topologyID); // Find the topology by its id
                string JSON = JsonConvert.SerializeObject(topology, Formatting.Indented); // convert it to json file

                string json_file_name = topologyID;
                File.WriteAllText(topologyID+".json", JSON ); // write the json into file

                return "Write Operation Successed!"; // return this if the write operation successed
            }
            catch
            {
                return "Write Opeartion Failed!"; // return this if the write operation failed
            }
        }

        // method to return all topologies in memory
        public static List<Topology> QueryTopologies()
        {
            return _topologies; // return all topologies
        }

        // method to remove specific topology from memroy
        public static string DeleteTopology(string topologyID)
        {
            try
            {
                Topology topology = _topologies.Find(x => x.id == topologyID); // 

                _topologies.Remove(topology);

                return "Delete Operation Successed"; // return this if the delete operation successed
            }
            catch
            {
                return "Delete Opeartion Failed!"; // return this if the delete operation failed
            }

        }

        //method to return components in specific topology
        public static List<Component> QueryDevices (string topologyID)
        {
            Topology topology =  _topologies.Find(x => x.id == topologyID); // find the topolgy has this id

            return topology.components; // return the components
        }

        //method to know which devices are connected to a given netlist node a given topology.
        public static List<Component> QueryDevices(string TopologyID , string NetlistNodeID)
        {
            Topology topology =  _topologies.Find(x => x.id == TopologyID); // find the topolgy has this id

            List<Component> components = topology.components.FindAll(x => x.netlist.ContainsKey(NetlistNodeID)); // return the components has this netlist node

            return components;
        }
    }
}

