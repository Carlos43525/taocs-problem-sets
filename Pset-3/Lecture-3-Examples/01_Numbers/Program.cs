using System;
using Tao.Help;

namespace _01_Numbers
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] numbers = {4, 8, 15, 16, 23, 50};

            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] == 50)
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