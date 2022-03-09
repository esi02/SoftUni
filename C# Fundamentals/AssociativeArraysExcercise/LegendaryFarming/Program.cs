using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] farm = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> keyItems = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool valanyrWon = false;
            bool shadowmourneWon = false;
            bool dragonwrathWon = false;

            keyItems.Add("shards", 0);
            keyItems.Add("fragments", 0);
            keyItems.Add("motes", 0);

            while (true)
            {
                string item = string.Empty;
                int quantity = 0;
                for (int i = 0; i < farm.Length; i++)
                {
                    item = farm[i + 1].ToLower();
                    quantity = int.Parse(farm[i]);
                    if (item != "shards"
                        && item != "fragments"
                        && item != "motes")
                    {
                        if (junk.ContainsKey(item))
                        {
                            junk[item] += quantity;
                        }
                        else
                        {
                            junk.Add(item, quantity);
                        }
                    }
                    else
                    {
                        keyItems[item] += quantity;
                        if (item == "shards" && keyItems[item] >= 250)
                        {
                            shadowmourneWon = true;
                            break;
                        }
                        else if (item == "fragments" && keyItems[item] >= 250)
                        {
                            valanyrWon = true;
                            break;
                        }
                        else if (item == "motes" && keyItems[item] >= 250)
                        {
                            dragonwrathWon = true;
                            break;
                        }
                    }
                    i++;
                }
                if (shadowmourneWon || valanyrWon || dragonwrathWon)
                {
                    break;
                }
                farm = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (valanyrWon)
            {
                keyItems["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            else if (shadowmourneWon)
            {
                keyItems["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (dragonwrathWon)
            {
                keyItems["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }

            keyItems = keyItems
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key,
                              x => x.Value);
            junk = junk
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key,
                              x => x.Value);

            foreach (var item in keyItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

