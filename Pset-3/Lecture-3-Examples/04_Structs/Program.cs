using System;
using Tao.Help;

namespace _04_Structs
{
    class Program
    {
        struct Person
        {
            public string name;
            public string number;
        }
        static int Main(string[] args)
        {
            Person[] people = new Person[3];

            people[0].name = "Carl";
            people[0].number = "617-555-0100";

            people[1].name = "Jeremiah";
            people[1].number = "617-555-0101";

            people[2].name = "Decimal";
            people[2].number = "617-555-0102";

            for (int i = 0; i < 3; i++)
            {
                if (string.Equals(people[i].name, "Carl"))
                {
                    Console.WriteLine(people[i].number);
                    return 0;
                }
            }
            Console.WriteLine("Not Found");
            return 1;

        }
    }
}