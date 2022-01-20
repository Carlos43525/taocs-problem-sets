using System;

namespace _02_StringPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "EMMA"; 
            // Reference type: 
            // String
            // Array
            // Dynamic

            // Value
            // int 
            // float 
            // char

            unsafe 
            {
                fixed (char* ptr = s) // Pin this to memory
                {
                    Console.WriteLine(s);
                    Console.WriteLine($"Address: {(long)ptr:X}");
                }
            }
        }
    }
}
