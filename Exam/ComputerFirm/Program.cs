using System;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double salesCounter = 0;
            double finalSales = 0;
            double finalSales1 = 0;
            double ratingCounter = 0;
            for (int i = 1; i <= n; i++)
            {
                int models = int.Parse(Console.ReadLine());
                int rating = models % 10;
                int sales = models / 10;
                if (rating == 2)
                {
                    finalSales = 0;
                    salesCounter += finalSales;
                    ratingCounter += 2;
                }
                else if (rating == 3)
                {
                    finalSales = sales / 2;
                    salesCounter += finalSales;
                    ratingCounter += 3;
                }
                else if (rating == 4)
                {
                    finalSales = sales * 0.70;
                    salesCounter += finalSales;
                    ratingCounter += 4;
                }
                else if (rating == 5)
                {
                    finalSales = sales * 0.85;
                    salesCounter += finalSales;
                    ratingCounter += 5;
                }
                else if (rating == 6)
                {
                    finalSales = sales;
                    salesCounter += finalSales;
                    ratingCounter += 6;
                }
            }
            Console.WriteLine($"{salesCounter:f2}");
            Console.WriteLine($"{ratingCounter/n:f2}");
        }
    }
}
