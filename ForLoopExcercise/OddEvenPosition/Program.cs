using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine(oddMin == double.MaxValue ? "OddMin=No,": $"OddMin={oddMin:f2},");
            Console.WriteLine(oddMax == double.MinValue ? "OddMax=No," : $"OddMax={oddMax:f2},");

            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine(evenMin == double.MaxValue ? "EvenMin=No," : $"EvenMin={evenMin:f2},");
            Console.WriteLine(evenMax == double.MinValue ? "EvenMax=No" : $"EvenMax={evenMax:f2}");
        }
    }
}
