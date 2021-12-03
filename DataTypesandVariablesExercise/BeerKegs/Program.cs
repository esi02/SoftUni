using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string largestName = string.Empty;
            double largestVolume = 0;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > largestVolume)
                {
                    largestVolume = volume;
                    largestName = model;
                }
            }
            Console.WriteLine(largestName);
        }
    }
}
