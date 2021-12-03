using System;

namespace RhombusofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top part
            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= n - row; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 1; j < row; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            //bottom part
           

        }
    }
}

