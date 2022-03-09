using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueuesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] toStack = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> opashka = new Queue<int>();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            for (int i = 0; i < n; i++)
            {
                opashka.Enqueue(toStack[i]);
            }

            for (int i = 1; i <= s; i++)
            {
                opashka.Dequeue();
            }

            if (opashka.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if (opashka.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(opashka.Min());
            }
        }
    }
}
