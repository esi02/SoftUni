using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());

            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            //------------------------------------------
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            decimal first = MaxProection(X1, Y1, X2, Y2);
            decimal second = MaxProection(x1, y1, x2, y2);

            if (first >= second)
            {
                ClosestPoint(X1, Y1, X2, Y2);
            }
            else
            {
                ClosestPoint(x1, y1, x2, y2);
            }
        }

        static void ClosestPoint(double X1, double Y1, double X2, double Y2)
        {
            double firstCoordinate = Math.Sqrt((X1 * X1) + (Y1 * Y1));
            double secondCoordinate = Math.Sqrt((X2 * X2) + (Y2 * Y2));
            if (firstCoordinate <= secondCoordinate)
            {
                Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
            }
        }
        static decimal MaxProection(double X1, double Y1, double X2, double Y2)
        {
            decimal xCoordinate = Math.Abs((decimal)X2 - (decimal)X1);
            decimal yCoordinate = Math.Abs((decimal)Y2 - (decimal)Y1);
            if (xCoordinate >= yCoordinate)
            {
                return xCoordinate;
            }
            else
            {
                return yCoordinate;
            }
        }
    }
}
