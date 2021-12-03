using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Sum(first, second);
            Subtract(first, second, third);
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Subtract(int first, int second, int third)
        {
            int result = Sum(first, second) - third;
            Console.WriteLine(result);
            return result;
        }
    }
}
