using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = new int[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                jagged[i][0] = 1;
                jagged[i][jagged[i].Length - 1] = 1;
                for (int j = 1; j < jagged[i].Length - 1; j++)
                {
                    jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
    }
}
