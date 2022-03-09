using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int life = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] maze = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                maze[i] = chars;
            }

            int marioRow = 0;
            int marioCol = 0;
            int peachRow = 0;
            int peachCol = 0;

            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze[i].Length; j++)
                {
                    if (maze[i][j] == 'M')
                    {
                        marioRow = i;
                        marioCol = j;
                    }
                    else if (maze[i][j] == 'P')
                    {
                        peachRow = i;
                        peachCol = j;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string move = input[0];
                int enemyRow = int.Parse(input[1]);
                int enemyCol = int.Parse(input[2]);
                //Spawn Enemy and mark empty space
                maze[enemyRow][enemyCol] = 'B';
                maze[marioRow][marioCol] = '-';
                //Move Mario
                if (move == "W")
                {
                    if (marioRow - 1 >= 0)
                    {
                        marioRow--;
                        life--;
                    }
                    else
                    {
                        life--;
                    }
                }
                else if (move == "S")
                {
                    if (marioRow + 1 < rows)
                    {
                        marioRow++;
                        life--;
                    }
                    else
                    {
                        life--;
                    }
                }
                else if (move == "A")
                {
                    if (marioCol - 1 >= 0)
                    {
                        marioCol--;
                        life--;
                    }
                    else
                    {
                        life--;
                    }
                }
                else if (move == "D")
                {
                    if (marioCol + 1 < maze[marioRow].Length)
                    {
                        marioCol++;
                        life--;
                    }
                    else
                    {
                        life--;
                    }
                }
                //Check life
                if (life <= 0)
                {
                    maze[marioRow][marioCol] = 'X';
                    Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                    break;
                }

                if (maze[marioRow][marioCol] == 'B')
                {
                    life -= 2;
                    if (life <= 0)
                    {
                        maze[marioRow][marioCol] = 'X';
                        Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                        break;
                    }
                    else
                    {
                        maze[marioRow][marioCol] = 'M';
                    }
                }
                else if (maze[marioRow][marioCol] == 'P')
                {
                    maze[marioRow][marioCol] = '-';
                    maze[peachRow][peachCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {life}");
                    break;
                }

                maze[marioRow][marioCol] = 'M';
            }

            for (int i = 0; i < maze.Length; i++)
            {
                Console.WriteLine(string.Join("", maze[i]));
            }
        }
    }
}
