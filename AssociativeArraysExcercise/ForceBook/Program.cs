using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                string[] commandArgs = command.Contains(" | ") ? command.Split(" | ") : command.Split(" -> ");
                string side = string.Empty;
                string user = string.Empty;
                if (command.Contains(" | "))
                {
                    side = commandArgs[0];
                    user = commandArgs[1];

                    if (forceBook.ContainsKey(side))
                    {
                        if (!forceBook.Values.Any(x => x.ToString() == user))
                        {
                            forceBook[side].Add(user);
                        }
                    }
                    else
                    {
                        forceBook.Add(side, new List<string> { user });
                    }

                }
                else
                {
                    side = commandArgs[1];
                    user = commandArgs[0];

                    if (forceBook.ContainsKey(side))
                    {
                        bool contains = false;
                        foreach (var sides in forceBook)
                        {
                            if (sides.Value.Contains(user))
                            {
                                contains = true;
                                break;
                            }
                        }
                        if (contains)
                        {
                            foreach (var sides in forceBook)
                            {
                                if (sides.Value.Any(x => x == user))
                                {
                                    forceBook[sides.Key].Remove(user);
                                    break;
                                }
                            }
                            forceBook[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                        else
                        {
                            forceBook[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                    else
                    {
                        forceBook.Add(side, new List<string> { user });
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                command = Console.ReadLine();
            }

            forceBook = forceBook
                .Where(x => x.Value.Count >= 1)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);



            foreach (var side in forceBook)
            {
                var users = side.Value.OrderBy(x => x).ToList();
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    for (int i = 0; i < side.Value.Count; i++)
                    {
                        Console.WriteLine($"! {users[i]}");
                    }
                }
            }
        }
    }
}
