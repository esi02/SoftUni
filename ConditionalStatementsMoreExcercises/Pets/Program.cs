using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double dogFoodInKgPerDay = double.Parse(Console.ReadLine());
            double catFoodInKgPerDay = double.Parse(Console.ReadLine());
            double turtleFoodInGramsPerDay = double.Parse(Console.ReadLine());

            double dogFood = days * dogFoodInKgPerDay;
            double catFood = days * catFoodInKgPerDay;
            double turtleFood = (days * turtleFoodInGramsPerDay) / 1000;
            double totalFood = dogFood + catFood + turtleFood;
            if (totalFood <= foodLeftInKg)
            {
                double foodLeft = foodLeftInKg - totalFood;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodNeeded = totalFood - foodLeftInKg;
                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
