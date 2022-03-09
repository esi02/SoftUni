using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(input, count);
        }

        private static string RepeatString(string input, int count)
        {

            for (int i = 1; i <= count; i++)
            {
                Console.Write(input);
            }
            return input;
        }
    }
}
