using System;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make;
        public string Model;
        public int Year;
    }
    class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}/nModel: {car.Model}/nYear: {car.Year}");
        }
    }
}
