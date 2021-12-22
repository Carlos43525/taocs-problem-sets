using System;
using Tao.Help;

namespace _04_Credit_Actual
{
    class ProgramNoComments
    {
        static void NoComments(string[] args)
        {
            long cardNumber = Input.GetLong("Number: ");
            long digit1 = 0, digit2 = 0, numberOfDigits = 0, sumOfOdds = 0, sumOfEvens = 0, multiple, firstTwoDigits;

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
                    multiple = 2 * digit1;
                    sumOfOdds += (multiple / 10) + (multiple % 10);
                }
                cardNumber /= 10;
                numberOfDigits++;
            }
            bool isValid = (sumOfEvens + sumOfOdds) % 10 == 0;
            firstTwoDigits = (digit1 * 10) + digit2;

            if (isValid && digit1 == 4 && numberOfDigits >= 13 && numberOfDigits <= 16)
            {
                Console.WriteLine("VISA");
            }
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
