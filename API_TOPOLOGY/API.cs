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
        private static List<Topology> _topologies;

        public static bool ReadJSON(string file_path)
        {
            var json = File.ReadAllText(file_path);
            var new_topology = JsonConvert.DeserializeObject<Topology>(json);

            _topologies.Add(new_topology);

            Console.WriteLine(_topologies[0].components[0].resistance);

            return true;
        }
        /*
        public static bool WriteJSON(Topology topology)
        {
            //todo
        }

        public static List<Topology> QueryTopologies();
        {
            //todo
        }

        public static bool DeleteTopology(string topologyID)
        {
            //todo
        }

        public static List<Component> QueryDevices (string topologyID)
        {
            //todo
        }

        public static List<Component> QueryDevicesWithNetlistNode(string TopologyID , string NetlistNodeID)
        {
            //todo
        }
        */
    }

}