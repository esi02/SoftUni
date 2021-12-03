using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar motor = new SportCar(450,10.8);
            Console.WriteLine(motor.FuelConsumption);
        }
    }
}
