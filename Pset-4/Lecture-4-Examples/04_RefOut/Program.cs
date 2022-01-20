using System;

namespace _04_RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // Does NOT need to be initialized i.e. int number = 1; 
            RefMethod(out number); // Pass by reference
            System.Console.WriteLine(number);
            // Expected output: 45
        }

        static void RefMethod(out int refArg)
        {
            refArg = 44; 
        }
    }
}

//         {
//             int number = 1; 
//             RefMethod(ref number); // Pass by reference
//             System.Console.WriteLine(number);
//             // Expected output: 45
//         }

//         static void RefMethod(ref int refArg)
//         {
//             refArg = refArg + 44;
//         }