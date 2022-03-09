using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPriceForKg = double.Parse(Console.ReadLine());
            double cacaPriceForKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double palamudPrice = skumriqPriceForKg + skumriqPriceForKg * 0.60;
            double palamudSum = palamudPrice * palamudKg;
            double safridPrice = cacaPriceForKg + cacaPriceForKg * 0.80;
            double safridSum = safridPrice * safridKg;
            double midiSum = midiKg * 7.50;
            double sumForAll = palamudSum + safridSum + midiSum;
            Console.WriteLine($"{sumForAll:f2}");
        }
    }
}
