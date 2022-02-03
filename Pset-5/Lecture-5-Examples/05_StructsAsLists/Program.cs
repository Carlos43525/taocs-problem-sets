using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_StructsAsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Engine> engines = new List<Engine>();
            // engines.Add(new Engine() { engineBlock = "iron", cylinderHead = "aluminum", valveCover ="plastic" });

            List<Engine> engines = new List<Engine>() {
               new Engine() { engineBlock = "iron", cylinderHead = "aluminum" },
               new Engine() { engineBlock = "iron", cylinderHead = "iron", valveCover = "aluminum" },
               new Engine() { engineBlock = "aluminum", cylinderHead = "aluminum", valveCover = "aluminum" }
            };

            Console.WriteLine(engines[0].cylinderHead);
        }
    }
}

// public struct Engine
// {
//     public string engineBlock;
//     public string cylinderHead;
//     public string valveCover;
// }