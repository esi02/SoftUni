using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            ReturnArea(width, height);
        }

        static void ReturnArea(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
