using System;


namespace API_TOPOLOGY
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(API.ReadJSON(@"F:\Study Comp IV\master micro\SW_tasks_shared\topology.json"));
            Console.WriteLine(API.ReadJSON(@"F:\Study Comp IV\master micro\SW_tasks_shared\topology(1).json"));
            Console.WriteLine(API.ReadJSON(@"F:\Study Comp IV\master micro\SW_tasks_shared\topology(2).json"));

            var topologies = API.QueryTopologies();

            API.DeleteTopology("top1");

             topologies = API.QueryTopologies();

            var temp = API.QueryDevices("top2","drain");


            //Console.WriteLine(API.WriteJSON(@"top1"));
        }
    }
}
