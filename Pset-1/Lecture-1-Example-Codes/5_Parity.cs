using System;
using Tao.Help;

namespace Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input.GetInt("n: ");

            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}