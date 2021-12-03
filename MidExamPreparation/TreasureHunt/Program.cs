using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();


            while (command != "Yohoho!")
            {
                string[] commandArgs = command.Split();

                string action = commandArgs[0];

                if (action == "Loot")
                {
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        if (!initialLoot.Contains(commandArgs[i]))
                        {
                            initialLoot.Insert(0, commandArgs[i]);
                        }
                    }
                }
                else if (action == "Drop")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= 0 && index < initialLoot.Count)
                    {
                        string temp = initialLoot.ElementAt(index);
                        initialLoot.RemoveAt(index);
                        initialLoot.Add(temp);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else
                {

                    List<string> stolenItems = new List<string>();
                    int count = int.Parse(commandArgs[1]);
                    count = Math.Min(initialLoot.Count, count);

                    for (int i = initialLoot.Count - count; i < initialLoot.Count; i++)
                    {
                        stolenItems.Add(initialLoot[i]);
                    }
                    Console.WriteLine(string.Join(", ", stolenItems));
                    initialLoot.RemoveRange(initialLoot.Count - count, count);
                }

                command = Console.ReadLine();
            }



            if (initialLoot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double averageGain = (double)initialLoot.Sum(x => x.Length) / (double)initialLoot.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }

        }
    }
}
