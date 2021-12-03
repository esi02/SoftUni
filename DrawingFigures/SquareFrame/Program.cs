using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top row: + - +
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //mid row: | - |
            for (int rows = 0; rows < n - 2; rows++)
            {
                Console.Write("|");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            //bottom row: + - +
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
