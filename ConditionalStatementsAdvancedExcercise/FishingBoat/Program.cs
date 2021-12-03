using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());

            double priceForBoat = 0;
            double discount = 1;
            if (season == "Spring")
            {
                priceForBoat = 3000;
                if (countFishers <= 6)
                {
                    discount = 0.90;
                }
                else if (countFishers >= 7 && countFishers <= 11)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.75;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceForBoat = 4200;
                if (countFishers <= 6)
                {
                    discount = 0.90;
                }
                else if (countFishers >= 7 && countFishers <= 11)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.75;
                }
            }
            else if (season == "Winter")
            {
                priceForBoat = 2600;
                if (countFishers <= 6)
                {
                    discount = 0.90;
                }
                else if (countFishers >= 7 && countFishers <= 11)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.75;
                }
            }
            double finalPrice = priceForBoat * discount;
            double bonusDiscount = 1;
            if (countFishers % 2 == 0 && season != "Autumn")
            {
                bonusDiscount = 0.95;
            }
            double finalSum = finalPrice * bonusDiscount;
            if (budget >= finalSum)
            {
                Console.WriteLine($"Yes! You have {budget - finalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalSum - budget:f2} leva.");
            }
        }
    }
}
