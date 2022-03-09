using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] fill = Console.ReadLine().Split();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = fill[cols];
                }
            }

            string command = Console.ReadLine();
            string[,] newMatrix = new string[sizes[0], sizes[1]];

            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "swap" && commandArgs.Length == 5)
                {
                    int row1 = int.Parse(commandArgs[1]);
                    int col1 = int.Parse(commandArgs[2]);
                    int row2 = int.Parse(commandArgs[3]);
                    int col2 = int.Parse(commandArgs[4]);

                    if (row1 >= 0 && col1 >= 0
                        && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1)
                        && row2 >= 0 && col2 >= 0
                        && row2 < matrix.GetLength(0) && col2 < matrix.GetLength(1))
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }

                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            Console.Write(matrix[rows, cols] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
