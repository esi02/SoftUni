using System;

namespace MethodsLab
{
    class Program
    {
        static void Main()
        {
            PrintSign();
        }

        static void PrintSign()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
