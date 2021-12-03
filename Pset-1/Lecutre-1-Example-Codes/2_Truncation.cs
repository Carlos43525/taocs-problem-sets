using System; 
using Tao.Help;

namespace Truncation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get numbers from user
            int x = Input.GetInt("x: ");
            int y = Input.GetInt("y: ");

            // Divide x by y 
            // Casting ints to floats
            float z = (float)x / (float)y; 
            System.Console.WriteLine(z);
        }
    }
}