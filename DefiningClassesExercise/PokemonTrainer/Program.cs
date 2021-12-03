using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
    public class Trainer
    {
        public string Name { get; set; }
        public int NumOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = inputArgs[0];
                string pokemonName = inputArgs[1];
                string pokemonElement = inputArgs[2];
                int pokemonHealth = int.Parse(inputArgs[3]);

                Pokemon current = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (trainers.Any(x => x.Name == trainerName))
                {
                    int index = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[index].Pokemons.Add(current);
                }
                else
                {
                    trainers.Add(new Trainer() { Name = trainerName, NumOfBadges = 0, Pokemons = new List<Pokemon>() { current } });
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Fire")
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(x => x.Element == input))
                        {
                            trainer.NumOfBadges++;
                        }
                        else
                        {
                            if (trainer.Pokemons.Count > 0)
                            {
                                foreach (var pokemon in trainer.Pokemons)
                                {
                                    if (pokemon.Health - 10 <= 0)
                                    {
                                        if (trainer.Pokemons.Count == 1)
                                        {
                                            trainer.Pokemons.Remove(pokemon);
                                            break;
                                        }
                                        else
                                        {
                                            trainer.Pokemons.Remove(pokemon);
                                        }
                                    }
                                    else
                                    {
                                        pokemon.Health -= 10;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (input == "Water")
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(x => x.Element == input))
                        {
                            trainer.NumOfBadges++;
                        }
                        else
                        {
                            if (trainer.Pokemons.Count > 0)
                            {
                                foreach (var pokemon in trainer.Pokemons)
                                {
                                    if (pokemon.Health - 10 <= 0)
                                    {
                                        if (trainer.Pokemons.Count == 1)
                                        {
                                            trainer.Pokemons.Remove(pokemon);
                                            break;
                                        }
                                        else
                                        {
                                            trainer.Pokemons.Remove(pokemon);
                                        }
                                    }
                                    else
                                    {
                                        pokemon.Health -= 10;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (input == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(x => x.Element == input))
                        {
                            trainer.NumOfBadges++;
                        }
                        else
                        {
                            if (trainer.Pokemons.Count > 0)
                            {
                                foreach (var pokemon in trainer.Pokemons)
                                {
                                    if (pokemon.Health - 10 <= 0)
                                    {
                                        if (trainer.Pokemons.Count == 1)
                                        {
                                            trainer.Pokemons.Remove(pokemon);
                                            break;
                                        }
                                        else
                                        {
                                            trainer.Pokemons.Remove(pokemon);
                                        }
                                    }
                                    else
                                    {
                                        pokemon.Health -= 10;
                                    }
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            trainers = trainers.OrderByDescending(x => x.NumOfBadges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
