using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Predicate<string>> filters = new List<Predicate<string>>();
            var temp = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "Print")
            {
                string[] commandArgs = command.Split(";");
                string action = commandArgs[0];
                string filterType = commandArgs[1];
                string parameter = commandArgs[2];


                if (action == "Add filter")
                {
                    if (temp.ContainsKey(filterType))
                    {
                        temp[filterType].Add(parameter);
                    }
                    else
                    {
                        temp.Add(filterType, new List<string>() { parameter });
                    }
                }
                else if (action == "Remove filter")
                {
                    if (temp[filterType].Count > 0)
                    {
                        temp[filterType].Remove(parameter);
                    }
                    else
                    {
                        temp.Remove(filterType);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in temp)
            {
                string action = item.Key;
                foreach (var letter in item.Value)
                {
                    string parameter = letter;
                    switch (action)
                    {
                        case "Starts with":
                            filters.Add(x => x.StartsWith(parameter));
                            break;
                        case "Ends with":
                            filters.Add(x => x.EndsWith(parameter));
                            break;
                        case "Length":
                            int len = int.Parse(parameter);
                            filters.Add(x => x.Length == len);
                            break;
                        case "Contains":
                            filters.Add(x => x.Contains(parameter));
                            break;
                    }

                }
            }

            invitations.RemoveAll(p => filters.Any(f => f(p)));
            Console.WriteLine(string.Join(" ", invitations));
        }
    }
}
