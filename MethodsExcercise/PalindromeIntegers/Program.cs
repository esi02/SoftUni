using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintPalindrome(input);
        }
        static bool PrintPalindrome(string input)
        {
            bool isEqual = false;

            while (input != "END")
            {
                int number = int.Parse(input);
                int originalNumber = number;
                int reversedNumber = 0;

                while (number > 0)
                {
                    int currentNumber = number % 10;
                    reversedNumber = (reversedNumber * 10) + currentNumber;
                    number /= 10;
                }

                isEqual = originalNumber.Equals(reversedNumber);

                if (isEqual)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();

            }

            return isEqual;
        }
    }
}
