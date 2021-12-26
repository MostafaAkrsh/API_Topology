using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using API_TOPOLOGY;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_1_readJSON_CorrectFile()
        {
            //Arrange
            string path = @"F:\Study Comp IV\master micro\SW_tasks_shared\topology.json";
            string expected = "Read Operation Successed!";

            //Act
            string actual = API_TOPOLOGY.API.ReadJSON(path);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_2_readJSON_WrongFile()
        {
            //Arrange
            string path = @"F:\Study Comp IV\master micro\SW_tasks_shared\muparser-2.3.2.zip";
            string expected = "Read Operation Failed!";

            //Act
            string actual = API_TOPOLOGY.API.ReadJSON(path);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_3_readJSON_PathWrong_test()
        {
            //Arrange
            string path = @"F:\Study Comp IV\master micro\SW_tass_shared\topolog.json";
            string expected = "Read Operation Failed!";

            //Act
            string actual = API_TOPOLOGY.API.ReadJSON(path);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_4_writeJSON_CorrectTopo()
        {
            //Arrange
            string path = @"F:\Study Comp IV\master micro\SW_tasks_shared\topology.json";
            API_TOPOLOGY.API.ReadJSON(path);

            string topology_id = "top1";
            string expected = "Write Operation Successed!";

            //Act
            string actual = API_TOPOLOGY.API.WriteJSON(topology_id);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_5_writeJSON_WrongTopo()
        {
            //Arrange
            string path = @"F:\Study Comp IV\master micro\SW_tasks_shared\topology.json";
            API_TOPOLOGY.API.ReadJSON(path);

            string topology_id = "t1";
            string expected = "No Topology has this id in memory!";

            //Act
            string actual = API_TOPOLOGY.API.WriteJSON(topology_id);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_6_queryTopologies()
        {
            //Arrange
            string path = @"F:\Study Comp IV\master micro\SW_tasks_shared\topology.json";
            API_TOPOLOGY.API.ReadJSON(path); //Call one more time 

            // Object Initialization in C#
            Topology topology1 = new Topology
            {
                Id = "top1",
                Components = new List<Component>{
                  new Component{
                     Type = "resistor",
                     Id = "res1",
                     Netlist = new Dictionary<string, string> {
                         { "t1" , "vdd" },
                         { "t2" , "n1" }
                     },
                     Resistance = new Resistance{
                        Def = 100,
                        Min = 10,
                        Max = 1000
                     }
                  },
                  new Component{
                     Type = "nmos",
                     Id = "m1",
                     Netlist = new Dictionary<string, string> {
                         { "drain" , "n1" },
                         { "gate" , "vin" },
                         { "source" , "vss" }
                     },
                     M = new M1{
                        Def = 1.5,
                        Min = 1,
                        Max = 2
                     }
                   }
                }
            };

            // Add this the list
            // There's 4 topologies in memory then add 4
            List<Topology> topologies = new List<Topology>();
            topologies.Add(topology1);
            topologies.Add(topology1);
            topologies.Add(topology1);
            topologies.Add(topology1);

            //Act
            List<Topology> topologies_test = API_TOPOLOGY.API.QueryTopologies();


            //Assert
            //Parsgin to json string to be able to compare it
            var expected = JsonConvert.SerializeObject(topologies);
            var actaul = JsonConvert.SerializeObject(topologies_test);
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void test_7_deleteTopology()
        {
            //Arrange
            API_TOPOLOGY.API.DeleteTopology("top1"); //Call one more time 

            // Object Initialization in C#
            Topology topology1 = new Topology
            {
                Id = "top1",
                Components = new List<Component>{
                  new Component{
                     Type = "resistor",
                     Id = "res1",
                     Netlist = new Dictionary<string, string> {
                         { "t1" , "vdd" },
                         { "t2" , "n1" }
                     },
                     Resistance = new Resistance{
                        Def = 100,
                        Min = 10,
                        Max = 1000
                     }
                  },
                  new Component{
                     Type = "nmos",
                     Id = "m1",
                     Netlist = new Dictionary<string, string> {
                         { "drain" , "n1" },
                         { "gate" , "vin" },
                         { "source" , "vss" }
                     },
                     M = new M1{
                        Def = 1.5,
                        Min = 1,
                        Max = 2
                     }
                   }
                }
            };

            // Add this the list
            // Now after delete one there are 3 in memory
            List<Topology> topologies = new List<Topology>();
            topologies.Add(topology1);
            topologies.Add(topology1);
            topologies.Add(topology1);

            //Act
            List<Topology> topologies_test = API_TOPOLOGY.API.QueryTopologies();


            //Assert
            //Parsgin to json string to be able to compare it
            var expected = JsonConvert.SerializeObject(topologies);
            var actaul = JsonConvert.SerializeObject(topologies_test);
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void test_8_queryDevices()
        {
            //Arrange
            Topology topology1 = new Topology
            {
                Id = "top1",
                Components = new List<Component>{
                  new Component{
                     Type = "resistor",
                     Id = "res1",
                     Netlist = new Dictionary<string, string> {
                         { "t1" , "vdd" },
                         { "t2" , "n1" }
                     },
                     Resistance = new Resistance{
                        Def = 100,
                        Min = 10,
                        Max = 1000
                     }
                  },
                  new Component{
                     Type = "nmos",
                     Id = "m1",
                     Netlist = new Dictionary<string, string> {
                         { "drain" , "n1" },
                         { "gate" , "vin" },
                         { "source" , "vss" }
                     },
                     M = new M1{
                        Def = 1.5,
                        Min = 1,
                        Max = 2
                     }
                   }
                }
            };

            List<Component> components = topology1.Components;

            //Act
            List<Component> components_test = API_TOPOLOGY.API.QueryDevices("top1");

            //Assert
            //Assert
            //Parsgin to json string to be able to compare it
            var expected = JsonConvert.SerializeObject(components);
            var actaul = JsonConvert.SerializeObject(components_test);
            Assert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void test_9_queryDevices_with_netlist()
        {
            //Arrange
            Topology topology1 = new Topology
            {
                Id = "top1",
                Components = new List<Component>{
                  new Component{
                     Type = "resistor",
                     Id = "res1",
                     Netlist = new Dictionary<string, string> {
                         { "t1" , "vdd" },
                         { "t2" , "n1" }
                     },
                     Resistance = new Resistance{
                        Def = 100,
                        Min = 10,
                        Max = 1000
                     }
                  },
                  new Component{
                     Type = "nmos",
                     Id = "m1",
                     Netlist = new Dictionary<string, string> {
                         { "drain" , "n1" },
                         { "gate" , "vin" },
                         { "source" , "vss" }
                     },
                     M = new M1{
                        Def = 1.5,
                        Min = 1,
                        Max = 2
                     }
                   }
                }
            };

            List<Component> components = topology1.Components.FindAll(x => x.Netlist.ContainsValue("vin"));


            //Act
            List<Component> components_test = API_TOPOLOGY.API.QueryDevices("top1", "vin");

            //Assert
            //Assert
            //Parsgin to json string to be able to compare it
            var expected = JsonConvert.SerializeObject(components);
            var actaul = JsonConvert.SerializeObject(components_test);
            Assert.AreEqual(expected, actaul);
        }

    }
}
