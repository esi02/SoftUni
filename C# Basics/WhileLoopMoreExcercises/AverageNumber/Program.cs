using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num = 0;
            for (int i = 0; i < n; i++)
            {
                num += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{num / n:f2}");
        }
    }
}
