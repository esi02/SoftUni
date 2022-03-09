using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //грешката ми беше, че не занулявах сумата и не бях запазила разликите в променливи извън цикъла. разликата винаги се смята
            int sum = 0;
            int previousSum = 0;
            int maxDiff = 0;
            int diff = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += int.Parse(Console.ReadLine());
                sum += int.Parse(Console.ReadLine());

                if (i > 1)
                {
                    diff = Math.Abs(sum - previousSum);
                }
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
                previousSum = sum;
                sum = 0;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
