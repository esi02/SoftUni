using System;
using System.Linq;
using System.Runtime;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] bakery = new char[size, size];

            int money = 0;
            int myRow = 0;
            int myCol = 0;
            int pillarOneRow = 0;
            int pillarOneCol = 0;
            int pillarTwoRow = 0;
            int pillarTwoCol = 0;
            int pillarCount = 0;

            for (int i = 0; i < bakery.GetLength(0); i++)
            {
                string values = Console.ReadLine();
                char[] splitted = values.ToCharArray();
                for (int j = 0; j < bakery.GetLength(1); j++)
                {
                    bakery[i,j] = splitted[j];
                    if (splitted[j] == 'S')
                    {
                        myRow = i;
                        myCol = j;
                    }
                    else if (splitted[j] == 'O')
                    {
                        pillarCount++;
                        if (pillarCount == 2)
                        {
                            pillarTwoRow = i;
                            pillarTwoCol = j;
                        }
                        else
                        {
                            pillarOneRow = i;
                            pillarOneCol = j;
                        }
                    }
                }
            }
            bool outOfBakery = false;
            while (true)
            {
                if (money >= 50)
                {
                    break;
                }
                string move = Console.ReadLine();
                bakery[myRow, myCol] = '-';

                if (move == "up")
                {
                    if (myRow - 1 >= 0)
                    {
                        myRow--;
                    }
                    else
                    {
                        outOfBakery = true;
                        break;
                    }
                }
                else if (move == "down")
                {
                    if (myRow + 1 < bakery.GetLength(0))
                    {
                        myRow++;
                    }
                    else
                    {
                        outOfBakery = true;
                        break;
                    }
                }
                else if (move == "left")
                {
                    if (myCol - 1 >= 0)
                    {
                        myCol--;
                    }
                    else
                    {
                        outOfBakery = true;
                        break;
                    }
                }
                else if (move == "right")
                {
                    if (myCol + 1 < bakery.GetLength(1))
                    {
                        myCol++;
                    }
                    else
                    {
                        outOfBakery = true;
                        break;
                    }
                }

                if (char.IsDigit(bakery[myRow,myCol]))
                {
                    double digit = char.GetNumericValue(bakery[myRow,myCol]);
                    money += (int)digit;
                    bakery[myRow, myCol] = 'S';
                }
                else if (bakery[myRow, myCol] == 'O')
                {
                    if (myRow == pillarOneRow && myCol == pillarOneCol)
                    {
                        bakery[myRow, myCol] = '-';
                        bakery[pillarTwoRow, pillarTwoCol] = 'S';
                        myRow = pillarTwoRow;
                        myCol = pillarTwoCol;
                    }
                    else
                    {
                        bakery[myRow, myCol] = '-';
                        bakery[pillarOneRow, pillarOneCol] = 'S';
                        myRow = pillarOneRow;
                        myCol = pillarOneCol;
                    }
                }
            }

            if (outOfBakery)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {money}");

            for (int i = 0; i < bakery.GetLength(0); i++)
            {
                for (int j = 0; j < bakery.GetLength(1); j++)
                {
                    Console.Write(bakery[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
