using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            Dictionary<string, int> racers = new Dictionary<string, int>();

            while (input != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string distancePattern = @"[0-9]";

                var racerName = Regex.Matches(input, namePattern);
                string name = string.Empty;

                foreach (var item in racerName)
                {
                    name += item;
                }

                var racerDistance = Regex.Matches(input, distancePattern);
                int distance = 0;

                foreach (var item in racerDistance)
                {
                    distance += int.Parse(item.ToString());
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += distance;
                }

                if (participants.Contains(name) && !racers.ContainsKey(name))
                {
                    racers.Add(name, distance);
                }


                input = Console.ReadLine();
            }

            racers = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Dictionary<string, int> toPrint = new Dictionary<string, int>();
            int count = 0;

            foreach (var item in racers)
            {
                count++;
                if (count < 4)
                {
                    toPrint.Add(item.Key, item.Value);
                }
            }

            Console.WriteLine($"1st place: {toPrint.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {toPrint.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {toPrint.Keys.ElementAt(2)}");
        }
    }
}
