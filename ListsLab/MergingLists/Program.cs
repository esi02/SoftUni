using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int biggerCollection = Math.Max(firstCollection.Count, secondCollection.Count);

            for (int i = 0; i < biggerCollection; i++)
            {
                if (i >= firstCollection.Count)
                {
                    result.Add(secondCollection[i]);
                }
                if (i >= secondCollection.Count)
                {
                    result.Add(firstCollection[i]);
                }
                if (i < firstCollection.Count && i < secondCollection.Count)
                {
                    result.Add(firstCollection[i]);
                    result.Add(secondCollection[i]);

                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
