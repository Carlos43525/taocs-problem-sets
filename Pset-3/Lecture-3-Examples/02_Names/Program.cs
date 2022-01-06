using System;
using Tao.Help;

namespace _02_Names
{
    class Program
    {
        static int Main(string[] args)
        {
            string[] names = {"Carl", "Decimal", "Justin"};

            for (int i = 0; i < 3; i++)
            {
                // if (names[i] == "carl")
                if (string.Equals(names[i], "Carl"))
                {
                    Console.WriteLine("Found");
                    return 0; 
                }
            }
            Console.WriteLine("Not found");
            return 1; 
        }
    }
}