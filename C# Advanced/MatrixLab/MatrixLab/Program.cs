using System;
using System.Linq;

namespace MatrixLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixDimensions[0], matrixDimensions[1]];

            int sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] matrixElement = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = matrixElement[col];
                    sum += matrix[rows, col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
