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

            Stack<int> stack = new Stack<int>();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            for (int i = 0; i < n; i++)
            {
                stack.Push(toStack[i]);
            }

            for (int i = 1; i <= s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
