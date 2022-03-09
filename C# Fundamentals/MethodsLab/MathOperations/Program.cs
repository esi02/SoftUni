using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Calculate(a, op, b);
        }

        private static double Calculate(int a, string op, int b)
        {
            double result = 0;
            switch (op)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            Console.WriteLine(Math.Round(result, 2));
            return result;
        }
    }
}
