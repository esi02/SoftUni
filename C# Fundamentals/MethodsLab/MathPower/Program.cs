using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            MathPow(n1, n2);
        }

        static double MathPow(double n1, int n2)
        {
            double result = 0;
            Console.WriteLine(Math.Pow(n1, n2));
            return result;
        }
    }
}
