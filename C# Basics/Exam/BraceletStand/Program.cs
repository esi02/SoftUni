using System;

namespace BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double terezaDailyMoney = double.Parse(Console.ReadLine());
            double dailyMoneyEarned = double.Parse(Console.ReadLine());
            double allCosts = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double savedMoney = terezaDailyMoney * 5;
            double earnedMoney = dailyMoneyEarned * 5;
            double totalSavedMoney = savedMoney + earnedMoney;
            totalSavedMoney -= allCosts;

            if (totalSavedMoney >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalSavedMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice - totalSavedMoney:f2} BGN.");
            }
        }
    }
}
