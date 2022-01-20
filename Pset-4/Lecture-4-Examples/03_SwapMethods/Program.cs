using System;

namespace _03_SwapMethods
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Swap(&x, &y); // Passing by reference
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");
        }

        unsafe static void Swap(int* a, int* b)
        {
            int tmp = *a; // tmp = 1
            *a = *b;       // a = 2
            *b = tmp;     // b = 1

            Console.WriteLine(); // Just for spacing
        }
    }
}


        // static void Main(string[] args)
        // {
        //     int x = 1;
        //     int y = 2;
        //     Swap(x, y); // Passing by value
        //     Console.WriteLine($"x: {x}");
        //     Console.WriteLine($"y: {y}");
        // }

        // static void Swap(int a, int b)
        // {
        //     int tmp = a; // tmp = 1
        //     a = b;       // a = 2
        //     b = tmp;     // b = 1

        //     Console.WriteLine(); // Just for spacing
        // }