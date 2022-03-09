using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int liters = 0;
            int tank = 0;
            for (int i = 1; i <= num; i++)
            {
                liters = int.Parse(Console.ReadLine());
                tank += liters;
                if (tank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    tank -= liters;
                    continue;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
