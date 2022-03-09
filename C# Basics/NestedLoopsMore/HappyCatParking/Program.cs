using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double sum = 0;
            double totalSum = 0;
            for (int d = 1; d <= days; d++)
            {
                sum = 0;
                for (int h = 1; h <= hoursPerDay; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        sum += 2.50;
                    }
                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                totalSum += sum;
                Console.WriteLine($"Day: {d} - {sum:f2} leva");
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
