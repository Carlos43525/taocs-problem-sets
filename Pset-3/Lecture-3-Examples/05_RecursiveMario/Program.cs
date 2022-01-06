using System;
using Tao.Help;

namespace _05_RecursiveMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = Input.GetInt("Height: ");
            
            Draw(height);
        }

        static void Draw(int h)
        {
            if (h == 0)
            {
                return; 
            }
            
            Draw(h - 1);

            for (int i = 0; i < h; i++)
            {
                Console.Write("#");
            }
                Console.WriteLine();
        }
    }
}