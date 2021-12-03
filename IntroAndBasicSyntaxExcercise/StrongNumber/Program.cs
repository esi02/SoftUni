using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var startNumber = inputNumber;
            int sum = 0;

            while (inputNumber > 0)
            {
                int currentNumber = inputNumber % 10;
                int factoriel = 1;
                for (int i = 1; i <= currentNumber; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
                inputNumber /= 10;
            }
            if (startNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
