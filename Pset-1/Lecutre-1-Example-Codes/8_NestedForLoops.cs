using System;
using Tao.Help;

namespace NestedForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("?");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
    The nested loop we ended up with in the lecture

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("?");
                    }
                }
                Console.Write("?");
                Console.WriteLine();
*/