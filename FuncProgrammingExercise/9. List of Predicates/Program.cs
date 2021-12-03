using System;
using System.Linq;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();


            int[] range = new int[endOfRange];
            int counter = 0;

            for (int i = 0; i < range.Length; i++)
            {
                counter++;
                range[i] = counter;
            }

            for (int i = 0; i < range.Length; i++)
            {
                if (dividers.All(x => range[i] % x == 0))
                {
                    Console.Write(range[i] + " ");
                }
            }
        }
    }
}
