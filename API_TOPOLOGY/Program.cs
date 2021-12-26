// <copyright file="Program.cs" company="MostafaAkrsh">
// Copyright (c) MostafaAkrsh. All rights reserved.
// </copyright>

namespace API_TOPOLOGY
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(API.ReadJSON(@"F:\Study Comp IV\master micro\SW_tasks_shared\topology.json"));
            Console.WriteLine(API.ReadJSON(@"F:\Study Comp IV\master micro\SW_tasks_shared\topology(1).json"));
            Console.WriteLine(API.ReadJSON(@"F:\Study Comp IV\master micro\SW_tasks_shared\topology(2).json"));

            var topologies = API.WriteJSON("top1");

            API.DeleteTopology("top1"); 


            var temp = API.QueryDevices("top2", "drain");

            // Console.WriteLine(API.WriteJSON(@"top1"));
        }
    }
}
