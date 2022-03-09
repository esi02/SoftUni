using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var name in names)
            {
                var charArr = name.ToCharArray();
                int sum = 0;
                foreach (var item in charArr)
                {
                    sum += item;
                }

                if (sum >= n)
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}
