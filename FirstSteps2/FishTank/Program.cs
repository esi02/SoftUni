using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            //изчисление
            double volume = lenght * width * height;
            double liters = volume * 0.001;
            double percentageSand = percentage * 0.01;
            double litersNeeded = liters * (1 - percentageSand);
            //принт
            Console.WriteLine(litersNeeded);

        }
    }
}
