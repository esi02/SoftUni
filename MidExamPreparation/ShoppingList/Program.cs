using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialGroceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (command[0] != "Go" && command[1] != "Shopping!")
            {
                if (command[0] == "Urgent")
                {
                    if (!initialGroceries.Contains(command[1]))
                    {
                        initialGroceries.Insert(0, command[1]);
                    }
                }
                if (command[0] == "Unnecessary")
                {
                    if (initialGroceries.Contains(command[1]))
                    {
                        initialGroceries.Remove(command[1]);
                    }
                }
                if (command[0] == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    if (initialGroceries.Contains(command[1]))
                    {
                        initialGroceries[initialGroceries.IndexOf(oldItem.ToString())] = newItem.ToString();
                    }
                }
                if (command[0] == "Rearrange")
                {
                    if (initialGroceries.Contains(command[1]))
                    {
                        initialGroceries.Remove(command[1]);
                        initialGroceries.Add(command[1]);
                    }
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            Console.WriteLine(string.Join(", ", initialGroceries));
        }
    }
}
