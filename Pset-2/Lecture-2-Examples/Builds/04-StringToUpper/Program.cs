using System;
using Tao.Help;

namespace _04_StringToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();

            Console.WriteLine(s.ToUpper());

            // for (int i = 0; i < s.Length; i++)
            // {
            //     if (s[i] >= 'a' && s[i] <= 'z')
            //     {
            //         char c = (char)(s[i] - 32);
            //         Console.WriteLine($"{c}");
            //     }
            //     else
            //     {
            //         Console.WriteLine("{1}", s[i]);
            //     }
            // }
        }
    }
}