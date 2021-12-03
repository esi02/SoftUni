using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double average = sequence.Average();

            List<int> topNumbers = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] > average)
                {
                    topNumbers.Add(sequence[i]);
                }
            }

            var print = topNumbers.OrderByDescending(x => x);
            int counter = 0;

            if (topNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in print)
                {
                    counter++;
                    if (counter > 5)
                    {
                        break;
                    }
                    Console.Write(item + " ");
                }
            }
        }
    }
}
