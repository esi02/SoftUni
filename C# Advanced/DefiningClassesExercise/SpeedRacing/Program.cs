using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Engine
    {
        public string Model { get; set; }
        public double Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
    }
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = string.Empty;
                double power = 0;
                int displacement = 0;
                string efficiency = string.Empty;
                if (input.Length == 4)
                {
                    model = input[0];
                    power = double.Parse(input[1]);
                    displacement = int.Parse(input[2]);
                    efficiency = input[3];
                    engines.Add(new Engine() { Model = model, Power = power, Displacement = displacement, Efficiency = efficiency });
                }
                else if (input.Length == 3)
                {
                    model = input[0];
                    power = double.Parse(input[1]);
                    if (char.IsDigit(input[2][0]))
                    {
                        displacement = int.Parse(input[2]);
                        engines.Add(new Engine() { Model = model, Power = power, Displacement = displacement });
                    }
                    else
                    {
                        efficiency = input[2];
                        engines.Add(new Engine() { Model = model, Power = power, Efficiency = efficiency });
                    }
                }
                else
                {
                    model = input[0];
                    power = double.Parse(input[1]);
                    engines.Add(new Engine() { Model = model, Power = power });
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = string.Empty;
                string engine = string.Empty;
                int weight = 0;
                string color = string.Empty;
                if (input.Length == 4)
                {
                    model = input[0];
                    engine = input[1];
                    weight = int.Parse(input[2]);
                    color = input[3];
                    allCars.Add(new Car() { Color = color, Model = model, Engine = engines.Find(x => x.Model == engine), Weight = weight });
                }
                else if (input.Length == 3)
                {
                    model = input[0];
                    engine = input[1];
                    if (char.IsDigit(input[2][0]))
                    {
                        weight = int.Parse(input[2]);
                        allCars.Add(new Car() { Model = model, Engine = engines.Find(x => x.Model == engine), Weight = weight });
                    }
                    else
                    {
                        color = input[2];
                        allCars.Add(new Car() { Model = model, Engine = engines.Find(x => x.Model == engine), Color = color });
                    }
                }
                else
                {
                    model = input[0];
                    engine = input[1];
                    allCars.Add(new Car() { Model = model, Engine = engines.Find(x => x.Model == engine) });
                }
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == "" || car.Engine.Efficiency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                if (car.Color == "" || car.Color == null)
                {
                    Console.WriteLine($"  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }

            }
        }
    }
}
