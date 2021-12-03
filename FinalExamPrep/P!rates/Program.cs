using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Cities> towns = new Dictionary<string, Cities>();

            while (input != "Sail")
            {
                string[] inputArgs = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = inputArgs[0];
                int population = int.Parse(inputArgs[1]);
                int gold = int.Parse(inputArgs[2]);

                if (towns.ContainsKey(town))
                {
                    towns[town].population += population;
                    towns[town].gold += gold;
                }
                else
                {
                    towns.Add(town, new Cities { gold = gold, population = population });
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = inputArgs[0];
                string town = inputArgs[1];

                if (action == "Plunder")
                {
                    int people = int.Parse(inputArgs[2]);
                    int gold = int.Parse(inputArgs[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (towns[town].gold - gold <= 0 || towns[town].population - people <= 0)
                    {
                        towns.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                    else
                    {
                        towns[town].gold -= gold;
                        towns[town].population -= people;
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(inputArgs[2]);
                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        towns[town].gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {towns[town].gold} gold.");
                    }
                }

                input = Console.ReadLine();
            }

            if (towns.Count < 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            towns = towns
                .OrderByDescending(x => x.Value.gold)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            foreach (var town in towns)
            {
                Console.WriteLine($"{town.Key} -> Population: {town.Value.population} citizens, Gold: {town.Value.gold} kg");
            }

        }
    }
    class Cities
    {
        public int population { get; set; }
        public int gold { get; set; }
    }
}
