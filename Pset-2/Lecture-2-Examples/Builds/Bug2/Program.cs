using System;
using Tao.Help;

namespace Bug2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = getNegativeInt();
            Console.WriteLine(i);
        }

        static int getNegativeInt()
        {
            int n;
            do
            {
                n = Input.GetInt("Negative integer: ");
            } while (n < 0);
            return n;
        }
    }
}
