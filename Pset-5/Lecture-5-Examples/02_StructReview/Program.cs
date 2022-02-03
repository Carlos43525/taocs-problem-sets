using System;

namespace _02_StructReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanicals.Engine toyota = new Mechanicals.Engine();
            Mechanicals.Engine honda = new Mechanicals.Engine();

            toyota.engineBlock = "iron";
            honda.engineBlock = "aluminum";

            Console.WriteLine(toyota.engineBlock);
            Console.WriteLine(honda.engineBlock);
        }
    }
}