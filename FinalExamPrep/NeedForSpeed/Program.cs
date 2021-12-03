using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 1; i <= n; i++)
            {
                string[] inputArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = inputArgs[0];
                int mileage = int.Parse(inputArgs[1]);
                int fuel = int.Parse(inputArgs[2]);

                cars.Add(car, new Car { fuel = fuel, mileage = mileage });

                if (i != n)
                {
                    input = Console.ReadLine();
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string car = commandArgs[1];

                if (action == "Drive")
                {
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    if (cars[car].fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car].mileage += distance;
                        cars[car].fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[car].mileage >= 100_000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(commandArgs[2]);
                    if (cars[car].fuel + fuel > 75)
                    {
                        Console.WriteLine($"{car} refueled with {75 - cars[car].fuel} liters");
                        cars[car].fuel = 75;
                    }
                    else
                    {
                        cars[car].fuel += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else
                {
                    int kilometers = int.Parse(commandArgs[2]);
                    if (cars[car].mileage - kilometers < 10_000)
                    {
                        cars[car].mileage = 10_000;
                    }
                    else
                    {
                        cars[car].mileage -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            cars = cars
                .OrderByDescending(x => x.Value.mileage)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.mileage} kms, Fuel in the tank: {car.Value.fuel} lt.");
            }
        }
    }
    class Car
    {
        public int mileage { get; set; }
        public int fuel { get; set; }
    }
}
