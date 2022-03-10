using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliiCount = int.Parse(Console.ReadLine());
            int zumbuliCount = int.Parse(Console.ReadLine());
            int roziCount = int.Parse(Console.ReadLine());
            int kaktusiCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliiPrice = 3.25;
            double zumbuliPrice = 4;
            double roziPrice = 3.50;
            double kaktusiPrice = 8;
            double totalPrice = (magnoliiCount * magnoliiPrice) + (zumbuliCount * zumbuliPrice) + (roziCount * roziPrice) + (kaktusiCount * kaktusiPrice);
            double totalSum = totalPrice * 0.95;
            if (totalSum >= giftPrice)
            {
                double moneyLeft = totalSum - giftPrice;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            }
            else
            {
                double moneyNeeded = giftPrice - totalSum;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
            }
        }
    }
}
