using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();

            Regex pattern = new Regex(@"(=|\/)[A-Z][A-Za-z]{2,}\1");

            var validLocations = pattern.Matches(places);
            int sum = 0;

            List<string> toList = new List<string>();
            foreach (var item in validLocations)
            {
                toList.Add(item.ToString());
            }

            for (int i = 0; i < toList.Count; i++)
            {
                toList[i] = toList[i].Replace("/", string.Empty);
                toList[i] = toList[i].Replace("=", string.Empty);
                sum += toList[i].Length;
            }


            Console.WriteLine($"Destinations: {string.Join(", ", toList)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
