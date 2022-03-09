using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string column = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = column[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            int roww = 0;
            int coll = 0;

            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                if (isFound)
                {
                    break;
                }
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        roww = row;
                        coll = col;
                        isFound = true;
                        break;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine($"({roww}, {coll})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
