using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] matrixElement = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = matrixElement[col];
                }
            }

            int biggestSum = int.MinValue;
            int[] topSquare = new int[2];
            int[] downSquare = new int[2];
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[rows, col] + matrix[rows, col + 1]
                        + matrix[rows + 1, col] + matrix[rows + 1, col + 1];
                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        topSquare[0] = matrix[rows, col];
                        topSquare[1] = matrix[rows, col + 1];
                        downSquare[0] = matrix[rows + 1, col];
                        downSquare[1] = matrix[rows + 1, col + 1];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", topSquare));
            Console.WriteLine(string.Join(" ", downSquare));
            Console.WriteLine(biggestSum);
        }
    }
}
