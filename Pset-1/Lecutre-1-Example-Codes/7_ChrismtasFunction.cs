using System;
using Tao.Help;

namespace ChristmasFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input and store it in "n"
            int n = Input.GetInt("How much Christmas?");
            // Run the Christmas() function and use "n" as our argument
            Christmans(n);
        }

        static void Christmans(int n)
        {
            // Print christmas n times, according to user input
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Christmas");
            }
        }
    }
}