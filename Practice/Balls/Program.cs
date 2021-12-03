using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double points = 0;
            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int othersCounter = 0;
            for (int i = 1; i <= N; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    points += 5;
                    redCounter++;
                }
                else if (color == "orange")
                {
                    points += 10;
                    orangeCounter++;
                }
                else if (color == "yellow")
                {
                    points += 15;
                    yellowCounter++;
                }
                else if (color == "white")
                {
                    points += 20;
                    whiteCounter++;
                }
                else if (color == "black")
                {
                    points = Math.Floor(points / 2);
                    blackCounter++;
                }
                else
                {
                    othersCounter++;
                    continue;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redCounter}");
            Console.WriteLine($"Points from orange balls: {orangeCounter}");
            Console.WriteLine($"Points from yellow balls: {yellowCounter}");
            Console.WriteLine($"Points from white balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked: {othersCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");
        }
    }
}
