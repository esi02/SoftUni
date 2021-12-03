using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[elements[0], elements[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] column = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = column[col];
                }
            }

            int sum = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, col];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
