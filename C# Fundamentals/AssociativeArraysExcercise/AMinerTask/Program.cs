using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, uint> sequence = new Dictionary<string, uint>();

            while (input != "stop")
            {
                string item = input;
                uint quantity = uint.Parse(Console.ReadLine());
                if (sequence.ContainsKey(item))
                {
                    sequence[item] += quantity;
                }
                else
                {
                    sequence.Add(item, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var item in sequence)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
