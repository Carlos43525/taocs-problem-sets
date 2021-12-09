using System;
using Tao.Help;

/// summary
/// Example solution for Cash problem
/// summary

namespace _01_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare height outisde of the bounds of the do/while loop 
             int height; 

            do
            {
                // Ask for input until user cooperates
                height = Input.GetInt("Height: ");
            }
            while (height < 1 || height > 8);  // Make sure height is not less than 1 or greater than 8

            // Outer for loop controls the flow of the entire program, running n times equal to height
            for (int row = 0; row < height; row++) 
            {
                // First loop iterates to print whitespaces equal to n - current loop iteration - 1
                for (int space = height - row - 1; space > 0; space--) 
                {
                    Console.Write(" ");
                }
                // Print hashes that is equal to current row + 1 (+1 because row is equal to 0)
                for (int hash = 0; hash < row + 1; hash++) 
                {
                    Console.Write("#");

                }
                // Start a new line in the console for the next iteration
                Console.WriteLine();
            }
        }
    }
}