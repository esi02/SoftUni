using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
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
            bool isChanged = false;
            while (command != "end")
            {
                string[] commandArgs = command.Split();

                string action = commandArgs[0];
                int num = 0;
                if (action == "Add")
                {
                    isChanged = true;
                    num = int.Parse(commandArgs[1]);
                    numbers.Add(num);
                }
                else if (action == "Remove")
                {
                    isChanged = true;
                    num = int.Parse(commandArgs[1]);
                    numbers.Remove(num);
                }
                else if (action == "RemoveAt")
                {
                    isChanged = true;
                    num = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(num);
                }
                else if (action == "Insert")
                {
                    isChanged = true;
                    num = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, num);
                }
                else if (action == "Contains")
                {
                    num = int.Parse(commandArgs[1]);
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    var evenNums = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNums));
                }
                else if (action == "PrintOdd")
                {
                    var oddNums = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNums));
                }
                else if (action == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (action == "Filter")
                {
                    string condition = commandArgs[1];
                    int number = int.Parse(commandArgs[2]);
                    if (condition == "<")
                    {
                        var isSmaller = numbers.FindAll(x => x < number);
                        Console.WriteLine(string.Join(" ", isSmaller));
                    }
                    if (condition == ">")
                    {
                        var isBigger = numbers.FindAll(x => x > number);
                        Console.WriteLine(string.Join(" ", isBigger));
                    }
                    if (condition == ">=")
                    {
                        var isBiggerOrEqual = numbers.FindAll(x => x >= number);
                        Console.WriteLine(string.Join(" ", isBiggerOrEqual));
                    }
                    if (condition == "<=")
                    {
                        var isSmallerOrEqual = numbers.FindAll(x => x <= number);
                        Console.WriteLine(string.Join(" ", isSmallerOrEqual));
                    }
                }

                command = Console.ReadLine();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
