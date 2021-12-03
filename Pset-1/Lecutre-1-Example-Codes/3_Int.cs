using System;
using Tao.Help;

namespace Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Input.GetInt("what's your age?");
            int days = age * 365; 

            Console.WriteLine($"You are at least {days} days old."); 

            // Different syntax to get the same thing: 

            // Console.WriteLine($"You are at least {age * 365} days old."); 
            // Console.WriteLine($"You are at least {0} days old.", age * 365); 
            // Console.WriteLine("You are at least {0} days old.", Input.GetInt("what's your age?") * 365); 
        }
    }
}