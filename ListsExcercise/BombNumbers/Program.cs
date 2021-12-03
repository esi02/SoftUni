using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> specialNumberAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int specialNumber = specialNumberAndPower[0];
            int power = specialNumberAndPower[1];

            while (numbers.Contains(specialNumber))
            {
                int index = numbers.IndexOf(specialNumber);
                int leftRange = power;
                int rightRange = power;
                if (index - leftRange < 0)
                {
                    leftRange = index;
                }
                if (index + rightRange >= numbers.Count)
                {
                    rightRange = numbers.Count - index - 1;
                }
                numbers.RemoveRange(index - leftRange, leftRange + rightRange + 1);
            }
            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}
