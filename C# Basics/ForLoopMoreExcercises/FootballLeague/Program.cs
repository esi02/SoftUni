using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadionCapacity = int.Parse(Console.ReadLine());
            int allFansCount = int.Parse(Console.ReadLine());

            double sectorAfans = 0;
            double sectorBfans = 0;
            double sectorVfans = 0;
            double sectorGfans = 0;
            for (int i = 1; i <= allFansCount; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        sectorAfans++;
                        break;
                    case "B":
                        sectorBfans++;
                        break;
                    case "V":
                        sectorVfans++;
                        break;
                    case "G":
                        sectorGfans++;
                        break;
                }
            }
            double allfans = sectorAfans + sectorBfans + sectorVfans + sectorGfans;
            Console.WriteLine($"{sectorAfans / allFansCount * 100:f2}%");
            Console.WriteLine($"{sectorBfans / allFansCount * 100:f2}%");
            Console.WriteLine($"{sectorVfans / allFansCount * 100:f2}%");
            Console.WriteLine($"{sectorGfans / allFansCount * 100:f2}%");
            Console.WriteLine($"{allfans / stadionCapacity * 100:f2}%");
        }
    }
}
