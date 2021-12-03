using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForKgVegetables = double.Parse(Console.ReadLine());
            double priceForKgFruits = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            double sumVegetables = priceForKgVegetables * kgVegetables;
            double sumFruits = priceForKgFruits * kgFruits;
            double finalSumInLv = sumVegetables + sumFruits;
            double finalSumInEuro = finalSumInLv / 1.94;

            Console.WriteLine($"{finalSumInEuro:f2}");
        }
    }
}
