using System;

namespace MethodsMoreExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            double num = 0;
            string text = string.Empty;

            if (input == "int")
            {
                number = int.Parse(Console.ReadLine());
                PrintResult(number);
            }
            else if (input == "real")
            {
                num = double.Parse(Console.ReadLine());
                PrintResult(num);
            }
            else
            {
                text = Console.ReadLine();
                PrintResult(text);
            }
        }
        static int PrintResult(int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
            return result;
        }
        static double PrintResult (double num)
        {
            double result = num * 1.5;
            Console.WriteLine($"{result:f2}");
            return result;
        }
        static string PrintResult (string text)
        {
            string result = text;
            Console.WriteLine($"${text}$");
            return result;
        }
    }
}
