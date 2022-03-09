using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //страничните стени
            double sidewall = x * y;
            double sidewallWindow = 1.5 * 1.5;
            double bothSidewalls = 2 * sidewall - 2 * sidewallWindow;
            //задните стени
            double backwall = x * x;
            double door = 1.2 * 2;
            double bothBackwalls = 2 * backwall - door;
            //обща площ на стените и боята
            double allWalls = bothSidewalls + bothBackwalls;
            double greenColor = allWalls / 3.4;
            //покрив
            double sidesOnRoof = 2 * (x * y);
            double trianglesOnRoof = 2 * (x * h / 2);
            //обща площ на покрива и боята
            double wholeRoof = sidesOnRoof + trianglesOnRoof;
            double redColor = wholeRoof / 4.3;
            //изход: колко литра боя ще ни трябва за страните и покрива
            Console.WriteLine($"{greenColor:f2}");
            Console.WriteLine($"{redColor:f2}");

        }
    }
}
