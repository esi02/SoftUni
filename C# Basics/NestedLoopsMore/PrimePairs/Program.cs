using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCouple = int.Parse(Console.ReadLine());
            int secondCouple = int.Parse(Console.ReadLine());
            int firstDiff = int.Parse(Console.ReadLine());
            int secondDiff = int.Parse(Console.ReadLine());

            int sum1 = firstCouple + firstDiff;
            int sum2 = secondCouple + secondDiff;
            for (int i = firstCouple; i <= sum1; i++)
            {
                for (int j = secondCouple; j <= sum2; j++)
                {
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && j % 2 != 0 && j % 3 != 0 && j % 5 != 0 && j % 7 != 0)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}


