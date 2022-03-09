using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalogue allVehicles = new Catalogue();


            while (command != "End")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeOfVehicle = commandArgs[0];
                string model = commandArgs[1];
                string color = commandArgs[2];
                int horsePower = int.Parse(commandArgs[3]);

                if (typeOfVehicle == "car")
                {
                    Car newCar = new Car();
                    newCar.Type = "Car";
                    newCar.Model = model;
                    newCar.Color = color;
                    newCar.HorsePower = horsePower;

                    allVehicles.Cars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck();
                    newTruck.Type = "Truck";
                    newTruck.Model = model;
                    newTruck.Color = color;
                    newTruck.HorsePower = horsePower;

                    allVehicles.Trucks.Add(newTruck);
                }
                command = Console.ReadLine();
            }

            string modelsOfVehicles = Console.ReadLine();

            while (modelsOfVehicles != "Close the Catalogue")
            {
                var cars = allVehicles
                                    .Cars
                                    .FindAll(x => x.Model == modelsOfVehicles).ToList();

                var trucks = allVehicles
                    .Trucks
                    .FindAll(x => x.Model == modelsOfVehicles).ToList();

                foreach (Car car in cars)
                {
                    Console.WriteLine($"Type: {car.Type}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Color: {car.Color}");
                    Console.WriteLine($"Horsepower: {car.HorsePower}");
                }
                foreach (Truck truck in trucks)
                {
                    Console.WriteLine($"Type: {truck.Type}");
                    Console.WriteLine($"Model: {truck.Model}");
                    Console.WriteLine($"Color: {truck.Color}");
                    Console.WriteLine($"Horsepower: {truck.HorsePower}");
                }

                modelsOfVehicles = Console.ReadLine();
            }

            decimal sumOfHorsePower = allVehicles.Cars.Sum(x => x.HorsePower);
            decimal averageHorsePowerOfCars = sumOfHorsePower / allVehicles.Cars.Count;

            decimal sumOfHorsePowerTrucks = allVehicles.Trucks.Sum(x => x.HorsePower);
            decimal averageHorsePowerOfTrucks = sumOfHorsePowerTrucks / allVehicles.Trucks.Count;

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerOfCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerOfTrucks:f2}.");
        }
    }

    class Car
    {
        public string Type;
        public string Model;
        public string Color;
        public int HorsePower;
    }
    class Truck
    {
        public string Type;
        public string Model;
        public string Color;
        public int HorsePower;
    }
    class Catalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
