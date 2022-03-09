using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int num = 0;
                if (action == "Add")
                {
                    num = int.Parse(commandArgs[1]);
                    numbers.Add(num);
                }
                else if (action == "Insert")
                {
                    num = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }
                }
                else if (action == "Remove")
                {
                    num = int.Parse(commandArgs[1]);
                    if (num < 0 || num >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(num);
                    }
                }
                else if (action == "Shift")
                {
                    string leftOrRight = commandArgs[1];
                    int number = int.Parse(commandArgs[2]);
                    if (leftOrRight == "left")
                    {
                        for (int i = 0; i < number % numbers.Count; i++)
                        {
                            int firstNum = numbers[0];
                            //add винаги мести в края
                            numbers.Add(firstNum);
                            numbers.RemoveAt(0);
                        }
                    }
                    if (leftOrRight == "right")
                    {
                        for (int i = 0; i < number % numbers.Count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNum);
                            numbers.RemoveAt(numbers.Count - 1);
                        }

                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
