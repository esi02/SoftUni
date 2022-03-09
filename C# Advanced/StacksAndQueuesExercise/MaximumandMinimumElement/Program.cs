using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNum = query[0];

                if (firstNum == 1)
                {
                    int elementToPush = query[1];
                    stack.Push(elementToPush);
                }
                else if (firstNum == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (firstNum == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (firstNum == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
