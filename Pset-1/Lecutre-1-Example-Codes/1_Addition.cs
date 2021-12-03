using System; 
using Tao.Help;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Input.GetInt("x: ");
            int y = Input.GetInt("y: ");

            Console.WriteLine(x + y);
        }
    }
}