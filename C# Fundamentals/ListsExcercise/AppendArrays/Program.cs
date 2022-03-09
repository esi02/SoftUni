using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numsAsStrings = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<int> result = new List<int>();

            foreach (var item in numsAsStrings)
            {
                result.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
