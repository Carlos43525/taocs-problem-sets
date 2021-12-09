using System;
using Tao.Help;

namespace _03_Cash_Actual
{
    class Program
    {
        static void Main(string[] args)
        {
            int centsOwed; 

            do 
            {
                float dollarsOwed = Input.GetFloat("Change owed: ");
                centsOwed = (int)MathF.Round(dollarsOwed * 100);
            }
            while (centsOwed <= 0);

            int quarters = centsOwed / 25; 
            int dimes = (centsOwed % 25) / 10;
            int nickels = ((centsOwed % 25) % 10) / 5; 
            int pennies = ((centsOwed % 25) % 10) % 5; 

            Console.WriteLine(quarters + dimes + nickels + pennies);
        }
    }
}