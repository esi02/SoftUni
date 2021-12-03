using System;
using System.Linq;

namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] column = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = column[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primarySum += matrix[row, row];
            }

            int collumn = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = collumn; col < matrix.GetLength(1); col++)
                {
                    secondarySum += matrix[row, col];
                    break;
                }
                collumn++;
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));

        }
    }
}
