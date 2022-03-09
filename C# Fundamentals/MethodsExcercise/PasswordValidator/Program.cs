using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (IsBetweenCharacters(input) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (ConsistsOfLettersAndDigits(input) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (HasAtLeastTwoDigits(input) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsBetweenCharacters(input) == true
                && ConsistsOfLettersAndDigits(input) == true
                && HasAtLeastTwoDigits(input) == true)
            {
                Console.WriteLine("Password is valid");
            }
           

        }
        static bool IsBetweenCharacters(string input)
        {
            bool isShorter = input.Length > 10 || input.Length < 6
                || input.Length > 10 && input.Length < 6;

            if (isShorter)
            {
                return isShorter = false;
            }
            return isShorter = true;

        }
        static bool ConsistsOfLettersAndDigits(string input)
        {
            bool isLetterOrDigit = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input, i))
                {
                    isLetterOrDigit = false;
                    break;
                }
            }
            return isLetterOrDigit;
        }
        static bool HasAtLeastTwoDigits(string input)
        {
            int digitCount = 0;
            bool hasDigits = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input, i))
                {
                    digitCount++;
                }
            }
            if (digitCount < 2)
            {
                hasDigits = false;
            }
            return hasDigits;
        }
    }
}
