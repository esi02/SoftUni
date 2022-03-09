using System;

namespace SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var number = 2 * i - 1;
                sum += number;
                Console.WriteLine(number);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
