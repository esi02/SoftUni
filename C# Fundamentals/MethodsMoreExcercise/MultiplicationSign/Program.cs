using System;
using System.Linq;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintTrueOrFalse(num1, num2, num3);
        }
        static string PrintTrueOrFalse(int num1, int num2, int num3)
        {
            string negative = "negative";
            string zero = "zero";
            string positive = "positive";

            bool isPositive = num1 < 0 && num2 < 0 || num1 < 0 && num3 < 0 || num2 < 0 && num3 < 0;

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine(zero);
                return zero;
            }
            if ((num1 > 0 && num2 > 0 && num3 > 0) 
                || (num1 < 0 && num2 < 0 && num3 > 0) 
                || (num1 < 0 && num2 > 0 && num3 < 0) 
                || (num1 > 0 && num2 < 0 && num3 < 0))
            {
                //ако има само едно отрицателно число, то резултата е положителен
                    Console.WriteLine(positive);
                    return positive;
            }
            else
            {
                Console.WriteLine(negative);
            }
            return negative;
        }
    }
}
