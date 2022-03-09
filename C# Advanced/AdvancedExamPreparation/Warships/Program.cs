using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] field = new string[size, size];
            string[] coordinates = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries);

            int playerOneShips = 0;
            int playerTwoShips = 0;
            int totalDestroyedShips = 0;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] columns = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = columns[j];
                    if (field[i, j] == "<")
                    {
                        playerOneShips++;
                    }
                    else if (field[i, j] == ">")
                    {
                        playerTwoShips++;
                    }
                }
            }

            for (int i = 0; i < coordinates.Length; i++)
            {
                if (playerOneShips <= 0 || playerTwoShips <= 0)
                {
                    break;
                }
                string[] attack = coordinates[i].Split();
                int row = int.Parse(attack[0]);
                int col = int.Parse(attack[1]);
                if (row < 0 || row >= field.GetLength(0)
                    || col < 0 || col >= field.GetLength(1))
                {
                    continue;
                }
                if (field[row, col] == "<")
                {
                    field[row, col] = "X";
                    totalDestroyedShips++;
                    playerOneShips--;
                }
                else if (field[row, col] == ">")
                {
                    field[row, col] = "X";
                    totalDestroyedShips++;
                    playerTwoShips--;
                }
                else if (field[row, col] == "#")
                {
                    //Upper ship
                    if (row - 1 >= 0)
                    {
                        var tempRow = row - 1;
                        if (field[tempRow, col] == "<")
                        {
                            field[tempRow, col] = "X";
                            playerOneShips--;
                            totalDestroyedShips++;
                        }
                        else if (field[tempRow, col] == ">")
                        {
                            field[tempRow, col] = "X";
                            playerTwoShips--;
                            totalDestroyedShips++;
                        }
                    }
                    //Down ship
                    if (row + 1 < field.GetLength(0))
                    {
                        var tempRow = row + 1;
                        if (field[tempRow, col] == "<")
                        {
                            field[tempRow, col] = "X";
                            playerOneShips--;
                            totalDestroyedShips++;
                        }
                        else if (field[tempRow, col] == ">")
                        {
                            field[tempRow, col] = "X";
                            playerTwoShips--;
                            totalDestroyedShips++;
                        }
                    }
                    //Left ship
                    if (col - 1 >= 0)
                    {
                        var tempCol = col - 1;
                        if (field[row, tempCol] == "<")
                        {
                            field[row, tempCol] = "X";
                            playerOneShips--;
                            totalDestroyedShips++;
                        }
                        else if (field[row, tempCol] == ">")
                        {
                            field[row, tempCol] = "X";
                            playerTwoShips--;
                            totalDestroyedShips++;
                        }
                    }
                    //Right ship
                    if (col + 1 < field.GetLength(1))
                    {
                        var tempCol = col + 1;
                        if (field[row, tempCol] == "<")
                        {
                            field[row, tempCol] = "X";
                            playerOneShips--;
                            totalDestroyedShips++;
                        }
                        else if (field[row, tempCol] == ">")
                        {
                            field[row, tempCol] = "X";
                            playerTwoShips--;
                            totalDestroyedShips++;
                        }
                    }
                    //Diagonal ship
                    if (row + 1 < field.GetLength(0) && col + 1 < field.GetLength(1))
                    {
                        var tempRow = row + 1;
                        var tempCol = col + 1;
                        if (field[tempRow, tempCol] == "<")
                        {
                            field[tempRow, tempCol] = "X";
                            playerOneShips--;
                            totalDestroyedShips++;
                        }
                        else if (field[tempRow, tempCol] == ">")
                        {
                            field[tempRow, tempCol] = "X";
                            playerTwoShips--;
                            totalDestroyedShips++;
                        }
                    }

                }
            }

            if (playerTwoShips == 0 && playerOneShips > 0)
            {
                Console.WriteLine($"Player One has won the game! {totalDestroyedShips} ships have been sunk in the battle.");
            }
            else if (playerOneShips == 0 && playerTwoShips > 0)
            {
                Console.WriteLine($"Player Two has won the game! {totalDestroyedShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }

        }
    }
}
