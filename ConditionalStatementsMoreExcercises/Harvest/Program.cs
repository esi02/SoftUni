using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double grapes = X * Y;
            double wineInLitres = (grapes * 0.40) / 2.5;
            if (wineInLitres >= Z)
            {
                double wineLeft = wineInLitres - Z;
                double winePerPerson = wineLeft / workersCount;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(wineInLitres)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");
            }
            else
            {
                double wineNeeded = Z - wineInLitres;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded)} liters wine needed.");
            }
        }
    }
}
