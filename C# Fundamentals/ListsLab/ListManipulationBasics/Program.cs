using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
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

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int num = int.Parse(commandArgs[1]);

                if (action == "Add")
                {
                    numbers.Add(num);
                }
                else if (action == "Remove")
                {
                    numbers.Remove(num);
                }
                else if (action == "RemoveAt")
                {
                    numbers.RemoveAt(num);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, num);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
