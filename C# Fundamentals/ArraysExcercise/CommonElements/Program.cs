using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] second = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string result = string.Empty;

            foreach (var item in second)
            {
                foreach (var item2 in first)
                {
                    if (item == item2)
                    {
                        result += string.IsNullOrEmpty(result) ? item : " " + item;
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
}
