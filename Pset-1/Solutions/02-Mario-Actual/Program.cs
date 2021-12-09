using System;
using Tao.Help;

namespace _02_Mario
{
    public class Program 
    {
        static void Main(string[] args)
        {
           int height; 
           int width; 

           do
           {
              height = Input.GetInt("Height: ");
              width = height; 
           } 
           while (height < 0 || height > 8);

            for (int i = 0; i <= height; i++)
            {
                int hash = i; 
                int spaces = width - hash; 

                Iterator(' ', spaces);
                Iterator('#', hash);

                Console.Write("  ");

                Iterator('#', hash);

                Console.WriteLine();
            }
          }

        static void Iterator(char c, int writeCount)
        {
            while (0 <= --writeCount) 
            {
                Console.Write(c);
            }
        }
    }
}