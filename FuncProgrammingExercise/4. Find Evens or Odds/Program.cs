using System;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();

            int start = bounds[0];
            int end = bounds[1];
            Predicate<int> isOdd = x => x % 2 != 0;

            for (int i = start; i <= end; i++)
            {
                if (isOdd(i) && condition == "odd")
                {
                    Console.Write(i + " ");
                }
                else if (!isOdd(i) && condition == "even")
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
