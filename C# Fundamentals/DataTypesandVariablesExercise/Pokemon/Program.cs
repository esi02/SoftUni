using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int pokeCounter = 0;
            int pokePower = originalPokePower;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCounter++;
                if (pokePower == originalPokePower / 2)
                {
                    if (exhaustion <= 0)
                    {
                        //runtime error was caused by this
                        continue;
                    }
                    pokePower /= exhaustion;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
