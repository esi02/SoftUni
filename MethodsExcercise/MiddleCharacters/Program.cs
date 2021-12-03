using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }
        static string PrintMiddleCharacter(string input)
        {
            string middleCharacter = string.Empty;
            string secondMiddleCharacter = string.Empty;
            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == input.Length / 2)
                    {
                        middleCharacter = input[i - 1].ToString();
                        secondMiddleCharacter = input[i].ToString();
                        Console.WriteLine(middleCharacter + secondMiddleCharacter);
                        break;
                    }
                }
                return middleCharacter + secondMiddleCharacter;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length / 2)
                {
                    middleCharacter = input[i].ToString();
                    Console.WriteLine(middleCharacter);
                    break;
                }
            }
            return middleCharacter;
        }
    }
}
