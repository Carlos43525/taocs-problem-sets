using System;
using System.Collections.Generic;

namespace _03_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumber = new List<int>();
            primeNumber.Add(1);
            primeNumber.Add(3);
            primeNumber.Add(5);
            primeNumber.Add(7);
            // 1, 3, 5, 7

            var cities = new List<string>();
            cities.Add("Toledo");
            cities.Add("Louisville");

            // collection-initializer syntax
            List<string> bigCities = new List<string>() 
            {
                "Chicago", 
                "LA", 
                "London"
            };

            bigCities.Add("Mumbai");
        }
    }
}