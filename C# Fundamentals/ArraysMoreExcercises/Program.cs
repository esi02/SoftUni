using System;
using System.Linq;

namespace ArraysMoreExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int currentNum = 0;
            for (int i = 1; i <= num; i++)
            {
                   string[] arr = Console.ReadLine()
                    .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (char j = '\0'; j < arr.Length; j++)
                {
                    if (arr[j].StartsWith("a") || arr[j].StartsWith("e") || arr[j].StartsWith("i") || arr[j].StartsWith("o") || arr[j].StartsWith("u"))
                    {
                        arr[j] = currentNum.ToString();
                        currentNum *= arr.Length;
                    }
                    else
                    {
                        arr[j] = currentNum.ToString();
                        currentNum /= arr.Length;
                    }
                }
            Console.WriteLine(arr.OrderBy(s => arr.Length - 1)
                .ToString());
            }
        }
    }
}
