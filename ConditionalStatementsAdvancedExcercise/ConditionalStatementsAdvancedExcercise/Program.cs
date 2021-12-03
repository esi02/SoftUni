using System;

namespace ConditionalStatementsAdvancedExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0;
            if (type == "Premiere")
            {
                income = rows * columns * 12;
            }
            else if (type == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else
            {
                income = rows * columns * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
