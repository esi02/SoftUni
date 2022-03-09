using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double tankCapacity;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            if (fuelQuantity > tankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }
        }

        public double FuelQuantity { get => this.fuelQuantity; set => this.fuelQuantity = value; }

        public double FuelConsumptionPerKm { get => this.fuelConsumptionPerKm; set => this.fuelConsumptionPerKm = value; }

        public double TankCapacity { get => this.tankCapacity; set => this.tankCapacity = value; }

        public void Drive(double distance)
        {
            double lostLiters = FuelConsumptionPerKm * distance;
            if (FuelQuantity - lostLiters >= 0)
            {
                FuelQuantity -= FuelConsumptionPerKm * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FuelQuantity + (liters * 0.95) > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (FuelQuantity + liters <= TankCapacity)
            {
                FuelQuantity += liters;
            }
        }
    }
}
