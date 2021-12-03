using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    continue;
                }
                if (count.ContainsKey(input[i]))
                {
                    count[input[i]]++;
                }
                else
                {
                    count.Add(input[i], 1);
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
