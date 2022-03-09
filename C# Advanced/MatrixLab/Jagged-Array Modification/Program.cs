using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] column = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = column[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Add")
                {
                    int row = int.Parse(commandArgs[1]);
                    int col = int.Parse(commandArgs[2]);
                    int value = int.Parse(commandArgs[3]);

                    if (row >= 0 && col >= 0
                        && row < matrix.GetLength(0) && col < matrix.GetLength(1))
                    {
                        matrix[row, col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (action == "Subtract")
                {
                    int row = int.Parse(commandArgs[1]);
                    int col = int.Parse(commandArgs[2]);
                    int value = int.Parse(commandArgs[3]);

                    if (row >= 0 && col >= 0
                        && row < matrix.GetLength(0) && col < matrix.GetLength(1))
                    {
                        matrix[row, col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[rows, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
