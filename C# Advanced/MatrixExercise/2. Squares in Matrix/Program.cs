using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] column = Console.ReadLine().Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = char.Parse(column[col]);
                }
            }

            int equalSum = 0;
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[rows, col] == matrix[rows, col + 1]
                        && matrix[rows, col] == matrix[rows + 1, col]
                        && matrix[rows, col] == matrix[rows + 1, col + 1])
                    {
                        equalSum++;
                    }
                }
            }
            Console.WriteLine(equalSum);
        }
    }
}
