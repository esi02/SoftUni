using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] column = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = column[col];
                }
            }
            int[,] squareMatrix = new int[3, 3];
            int leftCols = (matrix.GetLength(1) - 3) / 2;
            int leftRows = matrix.GetLength(0) - 3;

          

            for (int rows = matrix.GetLength(0) - 1; rows >= leftRows; rows--)
            {
                for (int cols = matrix.GetLength(1) - leftCols; cols >= leftCols; cols--)
                {

                }
            }
        }
    }
}
