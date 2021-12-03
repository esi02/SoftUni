using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOver20 = double.Parse(Console.ReadLine());
            double bagsKg = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int countOfBags = int.Parse(Console.ReadLine());

            double price = 0;

            if (bagsKg < 10)
            {
                price += priceOver20 * 0.20;
                if (days > 30)
                {
                    price *= 1.10;
                }
                else if (days >= 7 && days <= 30)
                {
                    price *= 1.15;
                }
                else
                {
                    price *= 1.40;
                }
            }
            else if (bagsKg >= 10 && bagsKg <= 20)
            {
                price += priceOver20 / 2;
                if (days > 30)
                {
                    price *= 1.10;
                }
                else if (days >= 7 && days <= 30)
                {
                    price *= 1.15;
                }
                else
                {
                    price *= 1.40;
                }
            }
            else
            {
                price = priceOver20;
                if (days > 30)
                {
                    price *= 1.10;
                }
                else if (days >= 7 && days <= 30)
                {
                    price *= 1.15;
                }
                else
                {
                    price *= 1.40;
                }
            }
            Console.WriteLine($"The total price of bags is: {price * countOfBags:f2} lv. ");
        }
    }
}
