using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    numbers = numbers.Select(x => x + 1).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToArray();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                command = Console.ReadLine();
            }
        }
    }
}
