using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder decrypted = new StringBuilder();

            Regex lettersPattern = new Regex(@"[star]", RegexOptions.IgnoreCase);


            string planetNamePattern = @"@[A-Za-z]+";
            string populationPattern = @":\d+";
            string attackPattern = @"![AD]!";
            string soldierPattern = @"->\d+";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                decrypted.Clear();
                int lettersCount = 0;

                var matches = lettersPattern.Matches(input);

                for (int k = 0; k < input.Length; k++)
                {
                    char currentSymbol = input[k];
                    currentSymbol -= (char)lettersCount;
                    decrypted.Append(currentSymbol);
                }

                var matchedName = Regex.Matches(decrypted.ToString(), planetNamePattern);
                bool matchedPopulation = Regex.IsMatch(decrypted.ToString(), populationPattern);
                var matchedAttack = Regex.Matches(decrypted.ToString(), attackPattern);
                bool matchedSoldier = Regex.IsMatch(decrypted.ToString(), soldierPattern);

                if (matchedName.Count > 0 && matchedPopulation && matchedAttack.Count > 0 && matchedSoldier)
                {
                    string name = string.Empty;
                    name += matchedName[0];
                    name = name.Replace("@", string.Empty);

                    string attack = string.Empty;
                    attack += matchedAttack[0];
                    attack = attack.Replace("!", string.Empty);

                    if (attack == "A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else if (attack == "D")
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();
            

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
