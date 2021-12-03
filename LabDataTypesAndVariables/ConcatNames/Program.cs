using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string symbol = Console.ReadLine();

            Console.WriteLine(firstName + symbol + secondName);
        }
    }
}
