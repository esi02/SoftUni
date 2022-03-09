using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine().ToLower();
            Stack<int> stack = new Stack<int>();


            foreach (var item in numbers)
            {
                stack.Push(item);
            }

            while (command != "end")
            {
                string[] commandsArgs = command.Split();
                string action = commandsArgs[0];

                if (action == "add")
                {
                    int firstNum = int.Parse(commandsArgs[1]);
                    int secondNum = int.Parse(commandsArgs[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else
                {
                    int num = int.Parse(commandsArgs[1]);
                    for (int i = 0; i < num; i++)
                    {
                        if (stack.Count >= num)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
