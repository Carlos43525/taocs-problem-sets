using System;
using System.Threading;
using Tao.Help;

namespace _01_Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = Input.GetIntFromString(args[i]);
            }

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                Visualize(arr, n);

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Sorted array: ");                
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Visualize(int[] arr, int n)
        {
            Console.Write("Current sort: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                Thread.Sleep(1000);
            }
            System.Console.WriteLine();
            Thread.Sleep(2000);
        }
    }
}