using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArraysMoreExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] inputArgs = input.Split(":");
                string contest = inputArgs[0];
                string password = inputArgs[1];

                contests.Add(contest, password);

                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> usersAndPoints = new Dictionary<string, Dictionary<string, int>>();

            string secondInput = Console.ReadLine();

            while (secondInput != "end of submissions")
            {
                string[] secondInputArgs = secondInput.Split("=>");
                string contest = secondInputArgs[0];
                string password = secondInputArgs[1];
                string username = secondInputArgs[2];
                int points = int.Parse(secondInputArgs[3]);


                if (usersAndPoints.ContainsKey(contest))
                {
                    if (usersAndPoints[contest].ContainsKey(username))
                    {
                        if (usersAndPoints[contest][username] < points)
                        {
                            usersAndPoints[contest][username] = points;
                        }
                    }
                    else
                    {
                        usersAndPoints[contest].Add(username, points);
                    }
                }
                else
                {
                    if (contests.ContainsKey(contest))
                    {
                        if (contests[contest] == password)
                        {
                            usersAndPoints.Add(contest, new Dictionary<string, int>()
                        {
                            {username, points }
                        });
                        }
                    }
                }
                secondInput = Console.ReadLine();
            }


            Dictionary<string, int> usersTotalPoints = new Dictionary<string, int>();

            foreach (var user in usersAndPoints)
            {
                foreach (var user1 in user.Value)
                {
                    usersTotalPoints[user1.Key] = user1.Value.Sum();
                    break;
                }
            }

            int maxPoints = usersTotalPoints
                .Values
                .Max();

            string bestCandidate = usersTotalPoints
                .Keys
                .Max();

            foreach (var kvp in usersTotalPoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }

            Console.WriteLine("Ranking:");
            foreach (var user in usersAndPoints)
            {
                foreach (var user1 in user.Value)
                {
                    Console.WriteLine(user.Key);
                    Console.WriteLine(string.Join(Environment.NewLine, user.Value
                        .OrderByDescending(x => x.Value)
                        .Select(x => $"# {x.Key} -> {x.Value}")));
                }
            }
        }
    }
}