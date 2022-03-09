using System;

namespace RefactorVolumeofPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length, width, height, volume = 0;
            length = decimal.Parse(Console.ReadLine());
            width = decimal.Parse(Console.ReadLine());
            height = decimal.Parse(Console.ReadLine());
            volume = (length * width * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
