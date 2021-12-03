using System;

namespace SumofChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= numOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
