using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] garden = new int[rows, cols];

            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    garden[i, j] = 0;
                }
            }

            Dictionary<int, int> plantedFlowers = new Dictionary<int, int>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Bloom Bloom Plow")
                {
                    break;
                }

                int[] coordinates = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];

                if (row < 0 || row >= garden.GetLength(0)
                    || col < 0 || col >= garden.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                else
                {
                    garden[row, col] = 1;
                    plantedFlowers.Add(row, col);
                }
            }


            for (int i = 0; i < plantedFlowers.Count; i++)
            {
                var coordinates = plantedFlowers.ElementAtOrDefault(i);
                int flowerRow = coordinates.Key;
                int flowerCol = coordinates.Value;

                var tempRow = flowerRow;
                var tempCol = flowerCol;
                //Up
                while (flowerRow >= 0)
                {
                    flowerRow--;
                    if (flowerRow < 0)
                    {
                        break;
                    }
                    if (garden[flowerRow, flowerCol] > 0)
                    {
                        garden[flowerRow, flowerCol]++;
                    }
                    else
                    {
                        garden[flowerRow, flowerCol] = 1;
                    }
                }
                flowerRow = tempRow;
                flowerCol = tempCol;
                //Down
                while (flowerRow < garden.GetLength(0))
                {
                    flowerRow++;
                    if (flowerRow == garden.GetLength(0))
                    {
                        break;
                    }
                    if (garden[flowerRow, flowerCol] > 0)
                    {
                        garden[flowerRow, flowerCol]++;
                    }
                    else
                    {
                        garden[flowerRow, flowerCol] = 1;
                    }
                }
                flowerRow = tempRow;
                flowerCol = tempCol;
                //Left
                while (flowerCol >= 0)
                {
                    flowerCol--;
                    if (flowerCol < 0)
                    {
                        break;
                    }
                    if (garden[flowerRow, flowerCol] > 0)
                    {
                        garden[flowerRow, flowerCol]++;
                    }
                    else
                    {
                        garden[flowerRow, flowerCol] = 1;
                    }
                }
                flowerRow = tempRow;
                flowerCol = tempCol;
                //Right
                while (flowerCol < garden.GetLength(1))
                {
                    flowerCol++;
                    if (flowerCol == garden.GetLength(1))
                    {
                        break;
                    }
                    if (garden[flowerRow, flowerCol] > 0)
                    {
                        garden[flowerRow, flowerCol]++;
                    }
                    else
                    {
                        garden[flowerRow, flowerCol] = 1;
                    }
                }
            }
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

