using System;
using Tao.Help;

namespace Caesar
{
    class Program
    {
        static int Main(string[] args)
        {
                int asciiOffset;
                const int LETTERS = 26;   // Represents alphabet size
                const int UPPERCASE = 65; // Uppercase ASCII begins at 65 
                const int LOWERCASE = 97; // Lowercase ASCII begins at 97

                if (args.Length != 1)
                {
                    Console.WriteLine("Usage: dotnet run key");
                    return 1;
                }

                // If k is > 26, store the remainder instead to "wrap" around
                // the alphabet. I.e. 27 % 26 = 1, 28 % 26 = 2, etc.
                int k = Input.GetIntFromString(args[0]) % LETTERS;

                Console.Write("Plaintext: ");
                string plaintext = Console.ReadLine();

                Console.Write("Ciphertext: ");

                for (int i = 0; i < plaintext.Length; i++)
                {
                    if (!Char.IsLetter(plaintext[i]))
                    {
                        Console.Write(plaintext[i]);
                    }
                    else
                    {
                        if (Char.IsUpper(plaintext[i]))
                        {
                            asciiOffset = UPPERCASE;
                        }
                        else
                        {
                            asciiOffset = LOWERCASE;
                        }

                        int pi = plaintext[i] - asciiOffset;
                        int ci = (pi + k) % LETTERS;
                        char output = (char)(ci + asciiOffset);

                        Console.Write($"{output}");
                    }
                }
                Console.WriteLine();
                return 0;
        }
    }
}