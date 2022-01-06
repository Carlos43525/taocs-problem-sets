using System;
using Tao.Help;

namespace _01_Caesar
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Enter a single int based argument");
                return 0;
            }

            string userinput = args[0];
            int numberinput = Input.GetIntFromString(userinput);
            Console.Write("Your key is: ");
            int key = numberinput % 26;
            Console.WriteLine($"{key}");
            Console.Write("Enter your plaintext: ");
            string plaintext = Console.ReadLine();
            Console.Write("Your cipher text is: ");

            for (int i = 0; i < plaintext.Length; i++)
            {

                if (!Char.IsLetter(plaintext[i]))
                {
                    Console.Write($"{plaintext[i]}");
                }
                else
                {

                    // subtract plaintext's char ascii number from 
                    // lowercase(97) or uppercase(65) start

                    // add the key and mod 26

                    // add back the lowercase(97) or uppercase(65) ascii number 

                    if (Char.IsUpper(plaintext[i]))
                    {
                        int pi = plaintext[i] - 65;
                        int ci = (pi + key) % 26; 
                        char c = (char)(ci + 65);
                        Console.Write($"{c}");
                    }
                    else
                    {
                        int pi = plaintext[i] - 97;
                        int ci = (pi + key) % 26; 
                        char c = (char)(ci + 97);
                        Console.Write($"{c}");
                    }
                }
            }

            Console.WriteLine();
            return 0;

        }
    }
}
//Console.Write($"{plaintext[i]}");


/*
string plaintext which is the user plaintext from readline 
move the plain text by a number of letters in the alphabet equal to the key
key is one for the example, I need to shift hello to ifmpp
*/
