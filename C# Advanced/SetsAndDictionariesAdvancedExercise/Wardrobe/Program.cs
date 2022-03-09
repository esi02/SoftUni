using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            if (n <= 0)
            {
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                string clothes = Console.ReadLine();
                string[] clothesArgs = clothes.Split(" -> ");
                string color = clothesArgs[0];
                string[] items = clothesArgs[1].Split(",");

                if (wardrobe.ContainsKey(color))
                {
                    for (int j = 0; j < items.Length; j++)
                    {
                        string item = items[j];
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    for (int j = 0; j < items.Length; j++)
                    {
                        string item = items[j];
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
            }
            
            string[] toPrint = Console.ReadLine().Split();
            string colorToPrint = toPrint[0];
            string itemToPrint = toPrint[1];

            foreach (var clothColor in wardrobe)
            {
                if (clothColor.Key == colorToPrint)
                {
                    Console.WriteLine($"{clothColor.Key} clothes:");
                    foreach (var itemCloth in clothColor.Value)
                    {
                        if (itemCloth.Key == itemToPrint)
                        {
                            Console.WriteLine($"* {itemCloth.Key} - {itemCloth.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {itemCloth.Key} - {itemCloth.Value}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{clothColor.Key} clothes:");
                    foreach (var itemm in clothColor.Value)
                    {
                        Console.WriteLine($"* {itemm.Key} - {itemm.Value}");
                    }
                }
            }
        }
    }
}
