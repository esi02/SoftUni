using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToList();

            int count = numbers.Count >= 3 ? 3 : numbers.Count;

            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
