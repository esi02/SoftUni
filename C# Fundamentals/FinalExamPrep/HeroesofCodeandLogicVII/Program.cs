using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, HeroPoints> heroes = new Dictionary<string, HeroPoints>();

            for (int i = 1; i <= n; i++)
            {
                string[] heroInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroInput[0];
                int hp = int.Parse(heroInput[1]);
                int mp = int.Parse(heroInput[2]);

                heroes.Add(heroName, new HeroPoints { HP = hp, MP = mp });
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = inputArgs[0];
                string heroName = inputArgs[1];

                if (action == "CastSpell")
                {
                    int mpNeeded = int.Parse(inputArgs[2]);
                    string spellName = inputArgs[3];
                    if (heroes[heroName].MP < mpNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroes[heroName].MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(inputArgs[2]);
                    string attacker = inputArgs[3];
                    if (heroes[heroName].HP <= damage)
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                    else
                    {
                        heroes[heroName].HP -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(inputArgs[2]);

                    if (heroes[heroName].MP + amount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroes[heroName].MP} MP!");
                        heroes[heroName].MP = 200;
                    }
                    else
                    {
                        heroes[heroName].MP += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(inputArgs[2]);

                    if (heroes[heroName].HP + amount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroes[heroName].HP} HP!");
                        heroes[heroName].HP = 100;
                    }
                    else
                    {
                        heroes[heroName].HP += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }

                input = Console.ReadLine();
            }

            heroes = heroes
                .Where(x => x.Value.HP > 0)
                .OrderByDescending(x => x.Value.HP)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }
    }
    class HeroPoints
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
