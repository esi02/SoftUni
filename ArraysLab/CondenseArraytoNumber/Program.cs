using System;
using System.Linq;

namespace CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            int[] condensed = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = arr[j] + arr[j + 1];

                }
                arr = condensed;
            }

            Console.WriteLine(condensed[0]);
        }
    }
}
