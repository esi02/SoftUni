using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                leftSum += number1;
            }
            for (int i = 1; i <= n; i++)
            {
                int number2 = int.Parse(Console.ReadLine());
                rightSum += number2;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
