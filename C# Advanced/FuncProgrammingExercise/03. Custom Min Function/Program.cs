using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int minValue = int.MaxValue;
            Func<int, bool> smallest = x => x < minValue;

            foreach (var num in integers)
            {
                if (smallest(num))
                {
                    minValue = num;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
