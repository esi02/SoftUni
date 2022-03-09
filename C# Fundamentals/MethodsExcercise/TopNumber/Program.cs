using System;
using System.Linq;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            PrintMasterNumbers(num);

        }
        static void PrintMasterNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (SumIsDivisible(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool SumIsDivisible(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int currentNum = num % 10;
                sum += currentNum;
                num /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool HasOddDigit(int num)
        {
            while (num > 0)
            {
                int currentNum = 0;
                currentNum = num % 10;
                if (currentNum % 2 != 0)
                {
                    return true;
                }

                num /= 10;
            }
            return false;
        }
    }
}
