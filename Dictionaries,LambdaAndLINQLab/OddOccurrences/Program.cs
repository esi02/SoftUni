using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCase = word.ToLower();
                if (occurences.ContainsKey(lowerCase))
                {
                    occurences[lowerCase]++;
                }
                else
                {
                    occurences.Add(lowerCase, 1);
                }
            }

            foreach (var count in occurences)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
