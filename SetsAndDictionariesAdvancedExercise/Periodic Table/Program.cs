using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueElemenets = new SortedSet<string>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {
                    uniqueElemenets.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueElemenets));
        }
    }
}
