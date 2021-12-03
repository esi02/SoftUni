using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();
            while (input != "end")
            {
                string[] vehicles = input
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = vehicles[0];
                string brand = vehicles[1];
                string model = vehicles[2];
                int power = int.Parse(vehicles[3]);

                if (type == "Car")
                {
                    Car current = new Car();
                    current.brand = brand;
                    current.model = model;
                    current.horsePower = power;

                    catalog.Cars.Add(current);
                }
                else
                {
                    Truck curr = new Truck();
                    curr.brand = brand;
                    curr.model = model;
                    curr.weight = power;

                    catalog.Trucks.Add(curr);
                }

                input = Console.ReadLine();
            }

            var newList = catalog.Cars.OrderBy(x => x.brand);
            var newList1 = catalog.Trucks.OrderBy(x => x.brand);

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in newList)
                {
                    Console.WriteLine($"{car.brand}: {car.model} - {car.horsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in newList1)
                {
                    Console.WriteLine($"{truck.brand}: {truck.model} - {truck.weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string brand;
        public string model;
        public int weight;
    }
    class Car
    {
        public string brand;
        public string model;
        public int horsePower;
    }
    class Catalog
    {
        //трябва да връща някаква стойност
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
