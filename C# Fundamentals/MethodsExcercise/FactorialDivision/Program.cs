using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            DivideFactoriel(n1, n2);
        }
        static double CalculateFirstFactoriel(int n1)
        {
            double resultFirst = n1;

            for (int i = n1 - 1; i >= 1; i--)
            {
                resultFirst *= i;
            }

            return resultFirst;
        }
        static double CalculateSecondFactoriel(int n2)
        {
            double resultSecond = n2;

            for (int i = n2 - 1; i >= 1; i--)
            {
                resultSecond *= i;
            }

            return resultSecond;
        }
        static double DivideFactoriel(int n1, int n2)
        {
            double finalResult = 0;
            finalResult = CalculateFirstFactoriel(n1) / CalculateSecondFactoriel(n2);

            Console.WriteLine($"{finalResult:f2}");
            return finalResult;
        }
    }
}
