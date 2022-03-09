using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string journal = Console.ReadLine();
            List<string> items = journal.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> command = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (command[0] != "Craft!")
            {
                if (command[0] == "Collect")
                {
                    if (items.Contains(command[1]))
                    {
                        command = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                        continue;
                    }
                    items.Add(command[1]);
                }
                if (command[0] == "Drop")
                {
                    string firstIndex = command[1].ToString();
                    if (items.Exists(firstIndex => items.Remove(command[1]))) { }
                }
                if (command[0] == "Combine Items")
                {
                    List<string> combine = command[1].Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
                    string oldItem = combine[0];
                    string newItem = combine[1];
                    if (items.Contains(oldItem) == true)
                    {
                        items.Insert(items.IndexOf(oldItem) + 1, newItem);
                    }
                    else
                    {
                        command = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                        continue;
                    }
                }
                if (command[0] == "Renew")
                {
                    string firstIndex = command[1].ToString();
                    if (items.Contains(firstIndex) == true)
                    {
                        items.Remove(command[1]);
                        items.Add(command[1]);
                    }
                }
                command = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
