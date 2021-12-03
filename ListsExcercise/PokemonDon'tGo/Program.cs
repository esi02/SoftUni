using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distancesToPokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            List<int> removedElemenets = new List<int>();

            int index = int.Parse(Console.ReadLine());

            while (distancesToPokemons.Count > 0)
            {
                if (index == 0 && distancesToPokemons.Count == 1)
                {
                    removedElemenets.Add(distancesToPokemons[index]);
                    distancesToPokemons.RemoveAt(index);
                    continue;
                }
                if (index < 0)
                {
                    removedElemenets.Add(distancesToPokemons[0]);
                    for (int i = 0; i < distancesToPokemons.Count; i++)
                    {
                        if (i == 0)
                        {
                            continue;
                        }
                        if (distancesToPokemons[i] > distancesToPokemons[0])
                        {
                            distancesToPokemons[i] -= distancesToPokemons[0];
                        }
                        else
                        {
                            distancesToPokemons[i] += distancesToPokemons[0];
                        }
                    }
                    distancesToPokemons.RemoveAt(0);
                    distancesToPokemons.Insert(0, distancesToPokemons.Count - 1);
                }
                if (index > distancesToPokemons.Count - 1)
                {
                    removedElemenets.Add(distancesToPokemons[distancesToPokemons.Count - 1]);
                    for (int i = 0; i < distancesToPokemons.Count; i++)
                    {
                        if (i == distancesToPokemons.Count - 1)
                        {
                            continue;
                        }
                        if (distancesToPokemons[i] > distancesToPokemons[distancesToPokemons.Count - 1])
                        {
                            distancesToPokemons[i] -= distancesToPokemons[distancesToPokemons.Count - 1];
                        }
                        else
                        {
                            distancesToPokemons[i] += distancesToPokemons[distancesToPokemons.Count - 1];
                        }
                    }
                    distancesToPokemons.Insert(distancesToPokemons.Count - 1, distancesToPokemons[0]);
                    distancesToPokemons.RemoveAt(distancesToPokemons.Count - 1);
                }
                if (index <= distancesToPokemons.Count - 1)
                {
                    for (int i = 0; i < distancesToPokemons.Count; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }
                        if (distancesToPokemons[i] > distancesToPokemons[index])
                        {
                            distancesToPokemons[i] -= distancesToPokemons[index];
                        }
                        else
                        {
                            distancesToPokemons[i] += distancesToPokemons[index];
                        }
                    }
                    removedElemenets.Add(distancesToPokemons[index]);
                    distancesToPokemons.RemoveAt(index);
                }

                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", removedElemenets.Sum()));
        }
    }
}
