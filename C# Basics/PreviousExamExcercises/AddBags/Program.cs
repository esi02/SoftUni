using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double bagsPriceOver20kg = double.Parse(Console.ReadLine());
            double bagsKg = double.Parse(Console.ReadLine());
            int daysUntilTravel = int.Parse(Console.ReadLine());
            int bagsCount = int.Parse(Console.ReadLine());

            double bagsPrice = 0;
            if (bagsKg < 10)
            {
                bagsPrice = bagsPriceOver20kg - (bagsPriceOver20kg - .20);
                if (daysUntilTravel < 7)
                {
                    bagsPrice = bagsPrice + (bagsPrice + .40);
                    Console.WriteLine($"The total price of bags is: {bagsPrice * bagsCount:f2} lv.");
                }
                if (daysUntilTravel >=7 && daysUntilTravel <= 30)
                {
                    bagsPrice = bagsPrice + (bagsPrice + .15);
                    Console.WriteLine($"The total price of bags is: {bagsPrice * bagsCount:f2} lv.");
                }
                if (daysUntilTravel > 30)
                {
                    bagsPrice = bagsPrice + (bagsPrice + .10);
                    Console.WriteLine($"The total price of bags is: {bagsPrice * bagsCount:f2} lv.");
                }
            }
            if (bagsKg >=10 && bagsKg <= 20)
            {
                bagsPrice = bagsPriceOver20kg / 2;
                if (daysUntilTravel < 7)
                {
                    bagsPrice = bagsPrice + (bagsPrice + .40);
                    Console.WriteLine($"The total price of bags is: {bagsPrice * bagsCount:f2} lv.");
                }
                if (daysUntilTravel >= 7 && daysUntilTravel <= 30)
                {
                    bagsPrice = bagsPrice + (bagsPrice + .15);
                    Console.WriteLine($"The total price of bags is: {bagsPrice * bagsCount:f2} lv.");
                }
                if (daysUntilTravel > 30)
                {
                    bagsPrice = bagsPrice + (bagsPrice + .10);
                    Console.WriteLine($"The total price of bags is: {bagsPrice * bagsCount:f2} lv.");
                }
                
            }
        }
    }
}
