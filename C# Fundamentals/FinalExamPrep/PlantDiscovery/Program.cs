using System;
using System.Collections.Generic;
using System.Linq;
namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Ratings> plants = new Dictionary<string, Ratings>();

            string input = Console.ReadLine();

            for (int i = 1; i <= n; i++)
            {
                string[] inputArgs = input.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = inputArgs[0];
                decimal rarity = decimal.Parse(inputArgs[1]);

                if (plants.ContainsKey(plant))
                {
                    plants[plant].rarity = rarity;
                }
                else
                {
                    plants.Add(plant, value: new Ratings { rarity = rarity, ratings = new List<decimal>() });
                }

                if (i != n)
                {
                    input = Console.ReadLine();
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                char[] separators = new char[] { ':', ' ', '-' };
                string[] commandArgs = command.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string plant = commandArgs[1];

                if (action == "Rate")
                {
                    decimal rating = decimal.Parse(commandArgs[2]);
                    plants[plant].ratings.Add(rating);
                }
                else if (action == "Update")
                {
                    decimal newRarity = decimal.Parse(commandArgs[2]);
                    plants[plant].rarity = newRarity;
                }
                else if (action == "Reset")
                {
                    plants[plant].ratings.Clear();
                }
                else
                {
                    Console.WriteLine("error");
                }

                command = Console.ReadLine();
            }

            foreach (var plant in plants)
            {
                decimal average = 0;
                if (plant.Value.ratings.Count > 0)
                {
                    average = plant.Value.ratings.Average();
                    plant.Value.ratings.Clear();
                    plant.Value.ratings.Add(average);
                }
                else
                {
                    plant.Value.ratings.Add(0);
                }
            }

            var newPlants = plants
                .OrderByDescending(x => x.Value.rarity)
                .ThenByDescending(x => x.Value.ratings[0]);

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in newPlants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.rarity}; Rating: {plant.Value.ratings[0]:f2}");
            }

        }
    }
    class Ratings
    {
        public decimal rarity { get; set; }
        public List<decimal> ratings { get; set; }

    }
}
