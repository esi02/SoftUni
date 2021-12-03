using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string name = commandArgs[1];

                if (action == "register")
                {
                    string plate = commandArgs[2];
                    if (cars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {cars[name]}");
                    }
                    else
                    {
                        cars.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (!cars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        cars.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
                if (i < n)
                {
                    command = Console.ReadLine();
                }
            }

            foreach (var user in cars)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
    }
}
