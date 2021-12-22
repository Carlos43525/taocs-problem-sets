using System;
using Tao.Help;

namespace _03_StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            string s = Console.ReadLine();

            for (int i = 0, n = s.Length; i < n; i++)
            {
                Console.WriteLine($"{s[i]}");
            }
        }
    }
}