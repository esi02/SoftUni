using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] vehicleOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] vehicleTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] vehicleThree = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string first = vehicleOne[0];
            string second = vehicleTwo[0];
            string third = vehicleThree[0];

            Car car = null;
            Truck truck = null;
            Bus bus = null;

            if (first == "Car")
            {
                double fuelQuantity = double.Parse(vehicleOne[1]);
                double fuelCons = double.Parse(vehicleOne[2]);
                double tankCapacity = double.Parse(vehicleOne[3]);
                car = new Car(fuelQuantity, fuelCons, tankCapacity);
            }
            else if (first == "Truck")
            {
                double fuelQuantity = double.Parse(vehicleOne[1]);
                double fuelCons = double.Parse(vehicleOne[2]);
                double tankCapacity = double.Parse(vehicleOne[3]);
                truck = new Truck(fuelQuantity, fuelCons, tankCapacity);
            }
            else if (first == "Bus")
            {
                double fuelQuantity = double.Parse(vehicleOne[1]);
                double fuelCons = double.Parse(vehicleOne[2]);
                double tankCapacity = double.Parse(vehicleOne[3]);
                bus = new Bus(fuelQuantity, fuelCons, tankCapacity);
            }

            if (second == "Car")
            {
                double fuelQuantity = double.Parse(vehicleTwo[1]);
                double fuelCons = double.Parse(vehicleTwo[2]);
                double tankCapacity = double.Parse(vehicleTwo[3]);
                car = new Car(fuelQuantity, fuelCons, tankCapacity);
            }
            else if (second == "Truck")
            {
                double fuelQuantity = double.Parse(vehicleTwo[1]);
                double fuelCons = double.Parse(vehicleTwo[2]);
                double tankCapacity = double.Parse(vehicleTwo[3]);
                truck = new Truck(fuelQuantity, fuelCons, tankCapacity);
            }
            else if (second == "Bus")
            {
                double fuelQuantity = double.Parse(vehicleTwo[1]);
                double fuelCons = double.Parse(vehicleTwo[2]);
                double tankCapacity = double.Parse(vehicleTwo[3]);
                bus = new Bus(fuelQuantity, fuelCons, tankCapacity);
            }

            if (third == "Car")
            {
                double fuelQuantity = double.Parse(vehicleThree[1]);
                double fuelCons = double.Parse(vehicleThree[2]);
                double tankCapacity = double.Parse(vehicleThree[3]);
                car = new Car(fuelQuantity, fuelCons, tankCapacity);
            }
            else if (third == "Truck")
            {
                double fuelQuantity = double.Parse(vehicleThree[1]);
                double fuelCons = double.Parse(vehicleThree[2]);
                double tankCapacity = double.Parse(vehicleThree[3]);
                truck = new Truck(fuelQuantity, fuelCons, tankCapacity);
            }
            else if (third == "Bus")
            {
                double fuelQuantity = double.Parse(vehicleThree[1]);
                double fuelCons = double.Parse(vehicleThree[2]);
                double tankCapacity = double.Parse(vehicleThree[3]);
                bus = new Bus(fuelQuantity, fuelCons, tankCapacity);
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = input[0];
                string vehicle = input[1];

                if (action == "Drive" && vehicle == "Car")
                {
                    double distance = double.Parse(input[2]);
                    car.Drive(distance);
                }
                else if(action == "Drive" && vehicle == "Truck")
                {
                    double distance = double.Parse(input[2]);
                    truck.Drive(distance);
                }
                else if(action == "Drive" && vehicle == "Bus")
                {
                    double distance = double.Parse(input[2]);
                    bus.FuelConsumptionPerKm = 1.4;
                    bus.Drive(distance);
                }
                else if (action == "DriveEmpty" && vehicle == "Bus")
                {
                    double distance = double.Parse(input[2]);
                    bus.Drive(distance);
                }
                else if (action == "Refuel" &&vehicle == "Car")
                {
                    double liters = double.Parse(input[2]);
                    car.Refuel(liters);
                }
                else if (action == "Refuel" &&vehicle == "Truck")
                {
                    double liters = double.Parse(input[2]);
                    truck.Refuel(liters);
                }
                else if (action == "Refuel" &&vehicle == "Bus")
                {
                    double liters = double.Parse(input[2]);
                    bus.Refuel(liters);
                }
            }
            Console.WriteLine($"Car: {Math.Round(car.FuelQuantity, 2):f2}");
            Console.WriteLine($"Truck: {Math.Round(truck.FuelQuantity, 2):f2}");
            Console.WriteLine($"Bus: {Math.Round(bus.FuelQuantity, 2):f2}");
        }
    }
}
