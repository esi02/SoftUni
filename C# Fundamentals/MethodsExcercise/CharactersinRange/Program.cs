using System;

namespace CharactersinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintInBetween(start, end);
        }

        static void PrintInBetween(char start, char end)
        {
            if (start > end)
            {
                for (int j = end + 1; j <= start - 1; j++)
                {
                    Console.Write((char)j + " ");
                }
            }
                for (int i = start + 1; i <= end - 1; i++)
                {
                    Console.Write((char)i + " ");
                }
            
        }
    }
}
