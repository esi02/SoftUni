using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, int> languagesAndSubmissions = new Dictionary<string, int>();

            Dictionary<string, List<int>> usersAndPoints = new Dictionary<string, List<int>>();

            while (command != "exam finished")
            {
                string[] commandArgs = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string username = commandArgs[0];
                string language = commandArgs[1];

                if (language == "banned")
                {
                    usersAndPoints.Remove(username);
                    command = Console.ReadLine();
                    continue;
                }

                int points = int.Parse(commandArgs[2]);

                if (languagesAndSubmissions.ContainsKey(language))
                {
                    languagesAndSubmissions[language]++;
                }
                else
                {
                    languagesAndSubmissions.Add(language, 1);
                }

                if (usersAndPoints.ContainsKey(username))
                {
                    usersAndPoints[username].Add(points);
                }
                else
                {
                    usersAndPoints.Add(username, new List<int> { points });
                }


                command = Console.ReadLine();
            }

            usersAndPoints = usersAndPoints
                .OrderByDescending(x => x.Value.Max())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            languagesAndSubmissions = languagesAndSubmissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var user in usersAndPoints)
            {
                Console.WriteLine($"{user.Key} | {user.Value.Max()}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in languagesAndSubmissions)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
