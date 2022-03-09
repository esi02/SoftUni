using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, names));
                    names.Clear();
                    input = Console.ReadLine();
                }
                names.Enqueue(input);
                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
