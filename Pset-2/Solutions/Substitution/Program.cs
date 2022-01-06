using System;
using Tao.Help;

namespace Substitution
{
    class Program
    {
        const string ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const int ALPHA_LENGTH = 26;

        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Provde only one command line argument.");
                return 1;
            }

            // Key validation
            int[] letters = new int[ALPHA_LENGTH];
            for (int i = 0; i < args[0].Length; i++)
            {
                if (!(args[0][i] >= 'a' && args[0][i] <= 'z') ||
                    (args[0][i] >= 'A' && args[0][i] <= 'Z'))
                {
                    Console.WriteLine("Key must only contain letters.");
                    return 1;
                } // Uppercasing
                else if (args[0][i] >= 'a' && args[0][i] <= 'z')
                {
                    // args[0][i] = 
                    Char.ToUpper(args[0][i]);
                }
                // Repeat letter validation
                for (int j = 0; j < args[0].Length; j++)
                {
                    if (args[0][i] == letters[j])
                    {
                        Console.WriteLine("Key must not contain repeated letters.");
                        return 1;
                    }
                }
                letters[i] = args[0][i];
            }

            // Obtain plaintext
            Console.WriteLine("Plaintext: ");
            string plaintext = Console.ReadLine();
            char[] ciphertext = new char[plaintext.Length];

            for (int i = 0; i < plaintext.Length; i++)
            {
                if (Char.IsUpper(plaintext[i]))
                {
                    for (int j = 0; j < plaintext.Length; j++)
                    {

                        if (plaintext[i] == ALPHA[j])
                        {
                            ciphertext[i] = args[0][j];
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < plaintext.Length; j++)
                    {

                        if (plaintext[i] == ALPHA[j])
                        {
                            ciphertext[i] = args[0][j];
                            break;
                        }
                    }
                }
            }
        }
    }
}
