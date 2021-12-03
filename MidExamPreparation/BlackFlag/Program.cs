using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    double additionalPlunder = (double)dailyPlunder * 0.50; //WHY DIDN'T VS TELL ME TO CAST
                    totalPlunder += additionalPlunder;
                }
                if (i % 5 == 0)
                {
                    totalPlunder *= 0.70;
                }

            }


            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double leftPlunder = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {leftPlunder:f2}% of the plunder.");
            }
        }
    }
}
