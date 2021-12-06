using System;
using Tao.Help;

namespace NestedForLoops
{
   class Program
    {
        // Get a POSITIVE integer from the user
        static void Main(string[] args)
        {
            // Tell C# that we have an int called "userInput" that's defined OUTSIDE the 
            // scope of the do/while loop. Remember that the do/while only has a scope, 
            // or domain within it's curly braces { }
            int userInput; 

            do
            {
                // Input.GetInt() returns an integer that the user entered. 
                // We store it into userInput
                userInput = Input.GetInt("Enter a positive number: ");

            } while (userInput < 1); 
            // We run our loop until the user enters a number that is 1 or greater.
            // Zero, is neither negative nor positive, thus we do not accept 1 as an answer.
            
            // Print the positive number
            Console.WriteLine($"{userInput} is a positive integer!");
        }
    }
}