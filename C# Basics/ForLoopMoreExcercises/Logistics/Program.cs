using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightCount = int.Parse(Console.ReadLine());

            double priceMikrobus = 0;
            double priceKamion = 0;
            double priceTrain = 0;
            //отново като миналите задачи винаги сумираме в цикъла за общите цени на всяко превозно средство
            double sumBus = 0;
            double sumKamion = 0;
            double sumTrain = 0;
            double sumWeight = 0;
            for (int i = 1; i <= weightCount; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                sumWeight += weight;
                if (weight <= 3)
                {
                    sumBus += weight;
                    priceMikrobus += 200 * weight;
                }
                if (weight >= 4 && weight <= 11)
                {
                    sumKamion += weight;
                    priceKamion += 175 * weight;
                }
                if (weight >= 12)
                {
                    sumTrain += weight;
                    priceTrain += 120 * weight;
                }
            }
            double averagePrice = (priceMikrobus + priceKamion + priceTrain) / sumWeight;
            double percentageMikrobus = sumBus / sumWeight * 100;
            double percentageKamion = sumKamion / sumWeight * 100;
            double percentageTrain = sumTrain / sumWeight * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentageMikrobus:f2}%");
            Console.WriteLine($"{percentageKamion:f2}%");
            Console.WriteLine($"{percentageTrain:f2}%");
        }
    }
}
