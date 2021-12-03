using System;

namespace GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double pricePerCostume = double.Parse(Console.ReadLine());

            double decorsPrice = budget * 0.10;
            double totalPriceForCostumes = pricePerCostume * extras;
            if (extras > 150)
            {
                totalPriceForCostumes = totalPriceForCostumes * 0.9;
            }
            double budgetNeeded = totalPriceForCostumes + decorsPrice;
            if (budgetNeeded <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - budgetNeeded:f2} leva left.");
            }
            else if (budgetNeeded > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budgetNeeded - budget):f2} leva more.");
            }
        }
    }
}
