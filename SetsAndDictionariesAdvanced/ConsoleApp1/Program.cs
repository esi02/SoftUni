using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (cities.ContainsKey(continent))
                {
                    if (cities[continent].ContainsKey(country))
                    {
                        cities[continent][country].Add(city);
                    }
                    else
                    {
                        cities[continent].Add(country, new List<string> { city });
                    }
                }
                else
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());
                    cities[continent].Add(country, new List<string> { city });
                }
            }

            foreach (var continent in cities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }

    }
}
