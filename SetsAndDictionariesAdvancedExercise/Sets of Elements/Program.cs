using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLenght = sizes[0];
            int secondLenght = sizes[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 1; i <= firstLenght; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstSet.Add(input);
            }
            for (int i = 1; i <= secondLenght; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondSet.Add(input);
            }
            var unique = new HashSet<int>();
            for (int i = 0; i < firstSet.Count; i++)
            {
                for (int j = 0; j < secondSet.Count; j++)
                {
                    if (firstSet.ElementAt(i).Equals(secondSet.ElementAt(j)))
                    {
                        unique.Add(firstSet.ElementAt(i));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", unique));
        }
    }
}
