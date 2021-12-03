using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = (Console.ReadLine());
            string square = "square";
            string rectangle = "rectangle";
            string circle = "circle";
            string triangle = "triangle";

            if (figureType == square)
            {
                double squareMeasuremenets = double.Parse(Console.ReadLine());
                double squareArea = Math.Round((squareMeasuremenets * squareMeasuremenets), 3);
                Console.WriteLine(squareArea);
            }
            else if (figureType == rectangle)
            {
                double rectangleMeasuremenets1 = double.Parse(Console.ReadLine());
                double rectangleMeasuremenets2 = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleMeasuremenets1 * rectangleMeasuremenets2;
                Console.WriteLine(Math.Round(rectangleArea, 3));
            }
            else if (figureType == circle)
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * (circleRadius * circleRadius);
                Console.WriteLine(Math.Round(circleArea,3));
            }
            else if (figureType == triangle)
            {
                double triangleMeasuremenets1 = double.Parse(Console.ReadLine());
                double triangleMeasuremenets2 = double.Parse(Console.ReadLine());
                double triangleArea = (triangleMeasuremenets1 * triangleMeasuremenets2) / 2;
                Console.WriteLine(Math.Round(triangleArea, 3));
            }

        }
    }
}
