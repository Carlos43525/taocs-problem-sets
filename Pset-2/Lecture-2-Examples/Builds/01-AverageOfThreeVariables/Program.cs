using System;
using Tao.Help;

namespace _01_AverageOfThreeVariables
{
    class Program
    {
        const int TOTAL = 3;
        static void Main(string[] args)
        {
            int[] scores = new int[TOTAL];

            for (int i = 0; i < TOTAL; i++)
            {
                scores[i] = Input.GetInt("Score: ");
            }

            Console.WriteLine(Average(TOTAL, scores));
        }

        static float Average(int length, int[] array)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += array[i];
            }
            return sum / (float)length;
        }
    }
}