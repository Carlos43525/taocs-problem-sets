using System; 
using Tao.Help;

namespace FloatingPointNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            float price = Input.GetFloat("What's the price?");
            Console.WriteLine("Your total is: {0:0.00}", price * 1.01625); // With a tax of 1.01625
        }
    }
}