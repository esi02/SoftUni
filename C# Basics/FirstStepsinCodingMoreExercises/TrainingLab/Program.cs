using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double w1 = w * 100 - 100;
            double h1 = h * 100;

            double desksPerRed = h1 / 70;
            double desks = Math.Floor(desksPerRed);
            double reds = w1 / 120;
            double red = Math.Floor(reds);
            double totalDesks = desks * red - 3;
            Console.WriteLine(totalDesks);
            //и моите начини бяха вярни, judge дава грешно
        }
    }
}
