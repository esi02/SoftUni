using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double puzzelCount = double.Parse(Console.ReadLine());
            double talkingDollCount = double.Parse(Console.ReadLine());
            double teddyBearsCount = double.Parse(Console.ReadLine());
            double minionCount = double.Parse(Console.ReadLine());
            double truckCount = double.Parse(Console.ReadLine());
            
            const double puzzelPrice = 2.60;
            const double talkingDollPrice = 3;
            const double teddyBearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;

            double countOfToys = puzzelCount + talkingDollCount + teddyBearsCount + minionCount + truckCount;
            double sum = puzzelCount * puzzelPrice + talkingDollCount * talkingDollPrice 
            + teddyBearsCount * teddyBearPrice + minionCount * minionPrice + truckCount * truckPrice;
            double discount = 0;
            if (countOfToys >= 50)
            {
                discount = sum * 0.25;
            }
            double finalSum = sum - discount;
            double rent = finalSum * 0.10;
            double moneyMade = finalSum - rent;
            if (excursionPrice > moneyMade)
            {
                double moneyNeeded = excursionPrice - moneyMade;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
            else
            {
                double moneyLeft = moneyMade - excursionPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
        }
    }
}
