using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int index = 0;
            while (input != "end")
            {
                if (input == "exchange")
                {
                    index = Console.Read();
                    break;
                }
            }
            Exchange(array, index);
        }
        static int[] Exchange(int[] array, int index)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[index + 1];
            }

            return newArray;
        }
    }
}
