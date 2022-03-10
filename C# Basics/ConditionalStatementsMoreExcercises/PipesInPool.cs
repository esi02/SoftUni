using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int VInLitres = int.Parse(Console.ReadLine());
            int P1forHour = int.Parse(Console.ReadLine());
            int P2forHour = int.Parse(Console.ReadLine());
            double Habsent = double.Parse(Console.ReadLine());

            double firstPipe = P1forHour * Habsent;
            double secondPipe = P2forHour * Habsent;
            double fullPool = firstPipe + secondPipe;
            if (fullPool <= VInLitres)
            {
                double firstPipePercentage = firstPipe / fullPool * 100;
                double secondPipePercentage = secondPipe / fullPool * 100;
                double poolPercentage = fullPool / VInLitres * 100;
                Console.WriteLine($"The pool is {poolPercentage:f2}% full. Pipe 1: {firstPipePercentage:f2}%. Pipe 2: {secondPipePercentage:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {Habsent:f2} hours the pool overflows with {fullPool - VInLitres:f2} liters.");
            }
        }
    }
}
