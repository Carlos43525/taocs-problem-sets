using System;
using Tao.Help;

namespace _03_Phonebook
{
    class Program
    {
        static int Main(string[] args)
        {
            string[] names = { "Carl", "Decimal", "Justin" };
            string[] numbers = { "617-555-0100", "617-555-0102", "617-555-0103" };

            for (int i = 0; i < 3; i++)
            {
                if (string.Equals(names[i], "Carl"))
                {
                    Console.WriteLine(numbers[i]);
                    return 0; 
                }
            }
            Console.WriteLine("Not found");
            return 1; 
        }
    }
}