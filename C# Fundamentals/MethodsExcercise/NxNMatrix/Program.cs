using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PrintMatrix(N);
        }
        static void PrintMatrix(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(N + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
