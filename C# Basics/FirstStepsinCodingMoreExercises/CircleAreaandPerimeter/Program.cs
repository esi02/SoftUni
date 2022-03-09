using System;

namespace CircleAreaandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * r * r;
            double circleParameter = 2 * Math.PI * r;

            Console.WriteLine($"{circleArea:f2}");
            Console.WriteLine($"{circleParameter:f2}");
        }
    }
}
