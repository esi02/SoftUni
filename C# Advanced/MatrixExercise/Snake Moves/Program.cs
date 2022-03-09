using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];
            string snake = Console.ReadLine();

            int last = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (rows % 2 == 0)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = snake[last].ToString();
                        if (last == snake.Length - 1)
                        {
                            last = 0;
                        }
                        else
                        {
                            last++;
                        }
                    }
                }
                else
                {
                    for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                    {
                        matrix[rows, i] = snake[last].ToString();

                        if (last == snake.Length - 1)
                        {
                            last = 0;
                        }
                        else
                        {
                            last++;
                        }
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
