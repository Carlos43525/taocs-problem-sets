using System;
using Tao.Help;

namespace _04_Credit_Actual
{
    class Program
    {
        /// /summary/
        /// Create a program that takes a credit card number from the user and returns VISA, AMEX, MASTERCARD, or INVALID.
        /// 
        /// Examples: 
        /// 4222222222222 Output: VISA
        /// 378282246310005 Output: AMEX 
        /// 5555555555554444 Output: MASTERCARD
        /// 3530111333300000 Output: INVALID
        /// 30569309025904 Output: INVALID
        /// /summary/
        static void Main(string[] args)
        {
            long cardNumber = Input.GetLong("Number: ");
            long digit1 = 0, digit2 = 0, numberOfDigits = 0, sumOfOdds = 0, sumOfEvens = 0, multiple, firstTwoDigits;

            // The primary objective of the while loop is to break our cc number down into its first two digits.
            // This is accomplished by dividing the card number by 10 at the end of each loop: 
            // 378282246310005 / 10 = 37828224631000
            // 37828224631000 /  10 = 3782822463100 
            // etc
            // We repeat this cycle until digit1 and digit2 contain our first numbers
            // Additionally, this loop has the additional functions of counting our number digits 
            // and keeping track of the number of even and odd digits for validation purposes with 
            // the use of Luhn's algorithm. Which is annotated in the comments below. 
            while (cardNumber > 0)
            {
                digit2 = digit1;
                digit1 = cardNumber % 10;

                if (numberOfDigits % 2 == 0)
                {
                    sumOfEvens += digit1;
                }
                else
                {
                    // Luhn 1: Multiply every other digit by 2, starting with the number’s 
                    // second-to-last digit, and then add those products’ digits together.
                    multiple = 2 * digit1;
                    // Luhn 2: Add the sum to the sum of the digits that weren’t multiplied by 2.
                    sumOfOdds += (multiple / 10) + (multiple % 10);
                }
                cardNumber /= 10;
                numberOfDigits++;
            }

            // Luhn 3: If the total’s last digit is 0 the number is valid.
            bool isValid = (sumOfEvens + sumOfOdds) % 10 == 0;
            firstTwoDigits = (digit1 * 10) + digit2;

            // If isValid = false there's no reason to continue the conditionals
            if (isValid && digit1 == 4 && numberOfDigits >= 13 && numberOfDigits <= 16)
            {
                Console.WriteLine("VISA");
            }
            // Remember that we are only concerened with 51-55 for Mastercard numbers
            else if (isValid && firstTwoDigits >= 51 && firstTwoDigits <= 55 && numberOfDigits == 16)
            {
                Console.WriteLine("MASTERCARD");
            }
            else if (isValid && firstTwoDigits == 34 || firstTwoDigits == 37 && numberOfDigits == 15)
            {
                Console.WriteLine("AMEX");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }
    }
}