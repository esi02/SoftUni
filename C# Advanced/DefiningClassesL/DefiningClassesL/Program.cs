using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;
        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
        public void Drive(double distance)
        {
            if ((FuelQuantity - distance) * FuelConsumption > 0)
            {
                FuelQuantity -= FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make} Model: {this.Model} Year: {this.Year} Fuel: {this.FuelQuantity:F2}";
        }
    }
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Tire[][] tires;
            List<Tire> temp = new List<Tire>();

            while (input != "No more tires")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < inputArgs.Length - 1; i++)
                {
                    int year = int.Parse(inputArgs[i]);
                    double pressure = double.Parse(inputArgs[i + 1]);
                    Tire tire = new Tire(year, pressure);
                    temp.Add(tire);
                    i++;
                }

                input = Console.ReadLine();
            }

            tires = new Tire[temp.Count / 4][];
            int start = 0;
            for (int i = 0; i < temp.Count; i += 3)
            {
                for (int j = start; j < tires.Length; j++)
                {
                    tires[j] = new Tire[4]
                        {
                        temp[i],
                        temp[i + 1],
                        temp[i + 2],
                        temp[i + 3]
                    };
                    break;

                }
                start++;
            }

            input = Console.ReadLine();
            List<Engine> engines = new List<Engine>();
            while (input != "Engines done")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(inputArgs[0]);
                double cubicCapacity = double.Parse(inputArgs[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            while (input != "Show special")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = inputArgs[0];
                string model = inputArgs[1];
                int year = int.Parse(inputArgs[2]);
                double fuelQuantity = double.Parse(inputArgs[3]);
                double fuelConsumption = double.Parse(inputArgs[4]);
                int engineIndex = int.Parse(inputArgs[5]);
                int tiresIndex = int.Parse(inputArgs[6]);
                Engine engine = engines[engineIndex];
                //cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine));

                input = Console.ReadLine();
            }

        }
    }
}
