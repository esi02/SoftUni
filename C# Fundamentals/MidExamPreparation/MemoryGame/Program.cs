using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            int moves = 0;

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                int index1 = int.Parse(commandArgs[0]);
                int index2 = int.Parse(commandArgs[1]);

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
                if (index1 == index2
                    || index1 > elements.Count
                    || index2 > elements.Count
                    || index1 < 0
                    || index2 < 0)
                {
                    moves++;
                    string elementToAdd = $"-{moves}a";

                    elements.Insert(elements.Count / 2, elementToAdd);
                    elements.Insert(elements.Count / 2, elementToAdd);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[index1] == elements[index2])
                {
                    moves++;
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");

                    if (index1 > index2)
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2);
                    }
                    else
                    {
                        elements.RemoveAt(index2);
                        elements.RemoveAt(index1);
                    }

                }
                else if (elements[index1] != elements[index2])
                {
                    moves++;
                    Console.WriteLine("Try again!");
                }

                command = Console.ReadLine();
            }

            if (elements.Any(x => x == x))
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
