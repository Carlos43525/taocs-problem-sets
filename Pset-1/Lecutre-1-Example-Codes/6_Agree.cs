using System;
using Tao.Help;

namespace Agree
{
    class Program // Overflow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you agree?");

            string input = Console.ReadLine();

            //Check whether agreed
            if (input == "Y" || input == "y")
            {
                Console.WriteLine("Agreed.");
            }
            else if (input == "N" || input == "n")
            {
                Console.WriteLine("Not agreed.");
            }
        }
    }
}