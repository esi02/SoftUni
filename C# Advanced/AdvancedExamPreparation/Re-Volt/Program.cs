using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int commands = int.Parse(Console.ReadLine());
            char[][] matrix = new char[matrixSize][];

            int playerRow = 0;
            int playerCol = 0;
            bool won = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string col = Console.ReadLine();
                matrix[i] = new char[matrix.GetLength(0)];
                for (int j = 0; j < col.Length; j++)
                {
                    matrix[i][j] = col[j];
                    if (col[j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }

            for (int i = 1; i <= commands; i++)
            {
                string input = Console.ReadLine();
                matrix[playerRow][playerCol] = '-';

                if (input == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        playerRow--;
                    }
                    else
                    {
                        playerRow = matrix.GetLength(0) - 1;
                    }
                }
                else if (input == "down")
                {
                    if (playerRow + 1 < matrix.GetLength(0))
                    {
                        playerRow++;
                    }
                    else
                    {
                        playerRow = 0;
                    }
                }
                else if (input == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;
                    }
                    else
                    {
                        playerCol = matrix[playerRow].Length - 1;
                    }
                }
                else if (input == "right")
                {
                    if (playerCol + 1 < matrix[playerRow].Length)
                    {
                        playerCol++;
                    }
                    else
                    {
                        playerCol = 0;
                    }
                }



                if (matrix[playerRow][playerCol] == 'B')
                {
                    if (input == "up")
                    {
                        if (playerRow - 1 >= 0)
                        {
                            playerRow--;
                        }
                        else
                        {
                            playerRow = matrix.GetLength(0) - 1;
                        }
                    }
                    else if (input == "down")
                    {
                        if (playerRow + 1 < matrix.GetLength(0))
                        {
                            playerRow++;
                        }
                        else
                        {
                            playerRow = 0;
                        }
                    }
                    else if (input == "left")
                    {
                        if (playerCol - 1 >= 0)
                        {
                            playerCol--;
                        }
                        else
                        {
                            playerCol = matrix[playerRow].Length - 1;
                        }
                    }
                    else if (input == "right")
                    {
                        if (playerCol + 1 < matrix[playerRow].Length)
                        {
                            playerCol++;
                        }
                        else
                        {
                            playerCol = 0;
                        }
                    }
                }
                else if (matrix[playerRow][playerCol] == 'T')
                {
                    if (input == "down")
                    {
                        if (playerRow - 1 >= 0)
                        {
                            playerRow--;
                        }
                        else
                        {
                            playerRow = matrix.GetLength(0) - 1;
                        }
                    }
                    else if (input == "up")
                    {
                        if (playerRow + 1 < matrix.GetLength(0))
                        {
                            playerRow++;
                        }
                        else
                        {
                            playerRow = 0;
                        }
                    }
                    else if (input == "right")
                    {
                        if (playerCol - 1 >= 0)
                        {
                            playerCol--;
                        }
                        else
                        {
                            playerCol = matrix[playerRow].Length - 1;
                        }
                    }
                    else if (input == "left")
                    {
                        if (playerCol + 1 < matrix[playerRow].Length)
                        {
                            playerCol++;
                        }
                        else
                        {
                            playerCol = 0;
                        }
                    }
                }
                else if (matrix[playerRow][playerCol] == 'F')
                {
                    matrix[playerRow][playerCol] = 'f';
                    won = true;
                    Console.WriteLine("Player won!");
                    break;
                }
                matrix[playerRow][playerCol] = 'f';
            }

            if (won == false)
            {
                Console.WriteLine($"Player lost!");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(new string(matrix[i]));
            }
        }
    }
}
