using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == thirdLetter)
                        {
                            continue;
                        }
                        if (j == thirdLetter)
                        {
                            continue;
                        }
                        if (k == thirdLetter)
                        {
                            continue;
                        }
                        counter++;
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
