using System;

namespace _01_Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe // Unmanaged code i.e. compiled straight to machine code
            {
                int number = 27;
                int* ptr = &number;

                Console.WriteLine($"Value of the variable: {number}");
                Console.WriteLine($"Value of the variable: {(long)ptr:X}");
            }
        }
    }
}
