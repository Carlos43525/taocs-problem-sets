﻿using System;
using Tao.Help;

namespace Bug1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"i is now: {i + 1}", i);
            }
        }
    }
}
