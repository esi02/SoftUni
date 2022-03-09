using System;

namespace Calculations
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (input == "add")
            {
                Add(num1, num2);
            }
            else if (input == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (input == "subtract")
            {
                Subtract(num1, num2);
            }
            else
            {
                Divide(num1, num2);
            }
        }

        static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
