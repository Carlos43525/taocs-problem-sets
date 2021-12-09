using System;
using Tao.Help;

namespace _03_Cash
{
    class Program
    {
        static void Main(string[] args)
        {
            // We store the number of coins we will return in int coins
            int coins = 0;
            int centsOwed;

            // Continously promt user until a positive dollar amount is entered
            do
            {
                float dollarsOwed = Input.GetFloat("Change owed: ");
                // Convert dollar amount to pennies by casting a rounded float into centsOwed
                // Multiply by 100 to negate the decimal place
                centsOwed = (int)MathF.Round(dollarsOwed * 100);
            }
            while (centsOwed <= 0);

            // While the size of a quarter (25) fits into centsOwed, increase coin amount
            // and subtract a quarter (25)
            while (centsOwed >= 25)
            {
                centsOwed -= 25;
                coins++;
            }
            // Once centsOwed is too small for quarters to fit, move to dimes
            // So on and so forth
            while (centsOwed >= 10)
            {
                centsOwed -= 10;
                coins++;
            }
            while (centsOwed >= 5)
            {
                centsOwed -= 5;
                coins++;
            }
            while (centsOwed >= 1)
            {
                centsOwed -= 1;
                coins++;
            }

            // Print the number of coins tallied by each while loop
            Console.WriteLine(coins);
        }
    }
}