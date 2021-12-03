using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] chessBoard = new char[8, 8];

            int blackRow = 0;
            int blackCol = 0;
            int whiteRow = 0;
            int whiteCol = 0;

            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    chessBoard[i, j] = row[j];
                    if (chessBoard[i, j] == 'b')
                    {
                        blackRow = i;
                        blackCol = j;
                    }
                    else if (chessBoard[i, j] == 'w')
                    {
                        whiteRow = i;
                        whiteCol = j;
                    }
                }
            }

            while (true)
            {
                chessBoard[whiteRow, whiteCol] = '-';
                //White turn - check if b is there
                if (whiteRow - 1 >= 0 && whiteCol - 1 >= 0)
                {
                    if (chessBoard[whiteRow - 1, whiteCol - 1] == 'b')
                    {
                        whiteRow--;
                        whiteCol--;
                        chessBoard[whiteRow, whiteCol] = 'w';
                        string crd = Coordinates(whiteRow, whiteCol);
                        Console.WriteLine($"Game over! White capture on {crd}.");
                        return;
                    }
                }
                //If it's not b, move up and check if it wins
                if (whiteRow - 1 == 0)
                {
                    whiteRow--;
                    chessBoard[whiteRow, whiteCol] = 'w';
                    string crd = Coordinates(whiteRow, whiteCol);
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {crd}.");
                    return;
                }
                else if (whiteRow - 1 >= 0)
                {
                    //If it doesn't win, continue with the move upwards
                    whiteRow--;
                    chessBoard[whiteRow, whiteCol] = 'w';
                }
                //Black turn
                chessBoard[blackRow, blackCol] = '-';
                //Check if w is there
                if (blackRow + 1 < chessBoard.GetLength(0) && blackCol + 1 < chessBoard.GetLength(1))
                {
                    if (chessBoard[blackRow + 1, blackCol + 1] == 'w')
                    {
                        blackRow++;
                        blackCol++;
                        chessBoard[blackRow, blackCol] = 'b';
                        string crd = Coordinates(blackRow, blackCol);
                        Console.WriteLine($"Game over! Black capture on {crd}.");
                        return;
                    }
                }
                //If it's not w, move up and check if it wins
                if (blackRow + 1 == chessBoard.GetLength(0) - 1)
                {
                    blackRow++;
                    chessBoard[blackRow, blackCol] = 'b';
                    string crd = Coordinates(blackRow, blackCol);
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {crd}.");
                    return;
                }
                else if (blackRow + 1 < chessBoard.GetLength(0))
                {
                    //If it doesn't win, continue with the move upwards
                    blackRow++;
                    chessBoard[blackRow, blackCol] = 'b';
                }
            }
        }
        public static string Coordinates(int row, int col)
        {
            string coordinates = string.Empty;
            switch (col)
            {
                case 0:
                    coordinates += "a";
                    break;
                case 1:
                    coordinates += "b";
                    break;
                case 2:
                    coordinates += "c";
                    break;
                case 3:
                    coordinates += "d";
                    break;
                case 4:
                    coordinates += "e";
                    break;
                case 5:
                    coordinates += "f";
                    break;
                case 6:
                    coordinates += "g";
                    break;
                case 7:
                    coordinates += "h";
                    break;
            }
            switch (row)
            {
                case 0:
                    coordinates += "8";
                    break;
                case 1:
                    coordinates += "7";
                    break;
                case 2:
                    coordinates += "6";
                    break;
                case 3:
                    coordinates += "5";
                    break;
                case 4:
                    coordinates += "4";
                    break;
                case 5:
                    coordinates += "3";
                    break;
                case 6:
                    coordinates += "2";
                    break;
                case 7:
                    coordinates += "1";
                    break;
            }
            return coordinates;
        }
    }
}
