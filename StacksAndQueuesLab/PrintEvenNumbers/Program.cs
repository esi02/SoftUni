using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> opashka = new Queue<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    opashka.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(", ", opashka));
        }
    }
}
