using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> manipulate = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int value = 0;
                string action = manipulate[0];
                int index = int.Parse(manipulate[1]);
                int secondIndex = int.Parse(manipulate[2]);

                if (action == "Shoot")
                {
                    if (targets.ElementAtOrDefault(index) != 0)
                    {
                        value = secondIndex;
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.Remove(targets[index]);
                        }
                    }
                }
                if (action == "Add")
                {
                    if (targets.ElementAtOrDefault(index) != 0)
                    {
                        value = secondIndex;
                        targets.Insert(index, secondIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                if (action == "Strike")
                {
                    if (index < 0
                        || index >= targets.Count
                        || index - secondIndex < 0
                        || index + secondIndex > targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        command = Console.ReadLine();
                        continue;
                    }

                    targets.RemoveRange(index - secondIndex,
                        secondIndex * 2 + 1);

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
