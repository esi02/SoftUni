using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacityPerWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Add")
                {
                    int newWagon = int.Parse(commandArgs[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int passengers = int.Parse(commandArgs[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] <= capacityPerWagon)
                        {
                            wagons[i] += passengers;
                            if (wagons[i] > capacityPerWagon)
                            {
                                wagons[i] -= passengers;
                                continue;
                            }
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
