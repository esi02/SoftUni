using System;

namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsiusDegrees = double.Parse(Console.ReadLine());

            double celsiusToF = (celsiusDegrees * 1.8) + 32;
            Console.WriteLine($"{celsiusToF:f2}");
        }
    }
}
