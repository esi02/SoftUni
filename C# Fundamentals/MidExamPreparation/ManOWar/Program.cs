using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maximumHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int damage = int.Parse(commandArgs[3]);
                    if (startIndex >= 0
                        && endIndex >= 0
                        && startIndex < pirateShip.Count
                        && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        if (pirateShip[index] + health < maximumHealth)
                        {
                            pirateShip[index] += health;
                        }
                        else
                        {
                            pirateShip[index] = maximumHealth;
                        }
                    }
                }
                else
                {
                    double lower = (double)maximumHealth * 0.20;
                    var needRepair = pirateShip.FindAll(x => x < lower);
                    Console.WriteLine($"{needRepair.Count} sections need repair.");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
