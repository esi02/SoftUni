using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameLogs = int.Parse(Console.ReadLine());

            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;
            double num6 = 0;

            double result = 0;
            for (int i = 1; i <= gameLogs; i++)
            {
                double num = int.Parse(Console.ReadLine());
                if (num >= 0 && num <= 9)
                {
                    num1++;
                    result += num * 0.20;
                }
                if (num >= 10 && num <= 19)
                {
                    num2++;
                    result += num * 0.30;
                }
                if (num >= 20 && num <= 29)
                {
                    num3++;
                    result += num * 0.40;
                }
                if (num >= 30 && num <= 39)
                {
                    num4++;
                    result += 50;
                }
                if (num >= 40 && num <= 50)
                {
                    num5++;
                    result += 100;
                }
                if (num < 0 || num > 50)
                {
                    num6++;
                    result = result / 2;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {num1 / gameLogs * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {num2 / gameLogs * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {num3 / gameLogs * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {num4 / gameLogs * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {num5 / gameLogs * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {num6 / gameLogs * 100:f2}%");
        }
    }
}
