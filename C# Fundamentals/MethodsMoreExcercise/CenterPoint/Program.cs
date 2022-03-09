using System;
using System.Linq;
using System.Numerics;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());

            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(X1, Y1, X2, Y2);
        }
        static void PrintClosestPoint(double X1, double Y1, double X2, double Y2)
        {
            //Х1 У1
            //Х2 У2
            double firstCoordinate = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
            double secondCoordinate = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            
            if (firstCoordinate < secondCoordinate)
            {
                Console.WriteLine($"({X1}, {Y1})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})");
            }
        }
    }
}
