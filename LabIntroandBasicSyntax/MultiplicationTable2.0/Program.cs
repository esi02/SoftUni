using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
