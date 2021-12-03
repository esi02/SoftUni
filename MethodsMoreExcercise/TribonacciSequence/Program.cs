using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 1;
            int d = a + b + c;
            PrintNumbers(num, a, b, c, d);
            Console.Write(a + " " + b + " " + c + " ");
        }
        static void PrintNumbers(int num, int a, int b, int c, int d)
        {
            Console.Write(a + " " + b + " " + c + " ");
            for (int i = 3; i <= num; i++)
            {
                Console.Write(d + " ");
                a = b;
                b = c;
                c = d;
                d = a + b + c;
            }
        }
    }
}
