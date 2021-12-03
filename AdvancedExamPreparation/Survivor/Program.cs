using System;
using System.Linq;
namespace Survivor
{
    class Program
    {
        public static bool isValidIndexes(int row, int col, string[][] beach)
        {
            return row >= 0 && row < beach.GetLength(0) && col >= 0 && col < beach[row].Length;
        }
        public static bool IsValid(int row, int col, string[][] beach)
        {
            if (isValidIndexes(row, col, beach))
            {
                return beach[row] != null && beach[row][col] != null && beach[row][col] != "-";
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] beach = new string[rows][];
            int collectedTokens = 0;
            int opponentTokens = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                beach[i] = new string[tokens.Length];
                for (int j = 0; j < tokens.Length; j++)
                {
                    beach[i][j] = tokens[j];
                }
            }
            string command = Console.ReadLine();

            while (command != "Gong")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);

                if (action == "Find")
                {
                    if (IsValid(row, col, beach))
                    {
                        collectedTokens++;
                        beach[row][col] = "-";
                    }
                }
                else if (action == "Opponent")
                {
                    string direction = commandArgs[3];
                    if (IsValid(row, col, beach))
                    {
                        opponentTokens++;
                        beach[row][col] = "-";
                        switch (direction)
                        {
                            case "up":
                                if (isValidIndexes(row - 3, col, beach))
                                {
                                    for (int i = row; i >= 0; i--)
                                    {
                                        if (beach[i][col] == "-")
                                        {
                                            continue;
                                        }
                                        opponentTokens++;
                                        beach[i][col] = "-";
                                    }
                                }
                                break;
                            case "down":
                                if (isValidIndexes(row + 3, col, beach))
                                {
                                    for (int i = row; i <= row + 3; i++)
                                    {
                                        if (beach[i][col] == "-")
                                        {
                                            continue;
                                        }
                                        opponentTokens++;
                                        beach[i][col] = "-";
                                    }
                                }
                                break;
                            case "left":
                                if (isValidIndexes(row, col - 3, beach))
                                {
                                    for (int i = col - 3; i >= 0; i--)
                                    {
                                        if (beach[i][col] == "-")
                                        {
                                            continue;
                                        }
                                        opponentTokens++;
                                        beach[i][col] = "-";
                                    }
                                }
                                break;
                            case "right":
                                if (isValidIndexes(row, col + 3, beach))
                                {
                                    for (int i = col; i <= col + 3; i++)
                                    {
                                        if (beach[i][col] == "-")
                                        {
                                            continue;
                                        }
                                        opponentTokens++;
                                        beach[i][col] = "-";
                                    }
                                }
                                break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var row in beach)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
