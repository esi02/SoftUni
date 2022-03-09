using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitedPeople = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                string condition = commandArgs[1];

                if (condition == "StartsWith")
                {
                    string start = commandArgs[2];
                    switch (action)
                    {
                        case "Remove":
                            invitedPeople = invitedPeople.Where(x => !x.StartsWith(start)).ToList();
                            break;
                        case "Double":
                            List<string> count = invitedPeople.FindAll(x => x.StartsWith(start));
                            if (count.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                int index = invitedPeople.IndexOf(count[0]);
                                invitedPeople.InsertRange(index, count);
                            }
                            break;
                    }
                }
                else if (condition == "EndsWith")
                {
                    string end = commandArgs[2];
                    switch (action)
                    {
                        case "Remove":
                            invitedPeople = invitedPeople.Where(x => !x.EndsWith(end)).ToList();
                            break;
                        case "Double":
                            List<string> count = invitedPeople.FindAll(x => x.EndsWith(end));
                            if (count.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                int index = invitedPeople.IndexOf(count[0]);
                                invitedPeople.InsertRange(index, count);
                            }
                            break;
                    }
                }
                else if (condition == "Length")
                {
                    int length = int.Parse(commandArgs[2]);
                    switch (action)
                    {
                        case "Remove":
                            invitedPeople = invitedPeople.Where(x => x.Length != length).ToList();
                            break;
                        case "Double":
                            List<string> count = invitedPeople.FindAll(x => x.Length == length);
                            if (count.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                int index = invitedPeople.IndexOf(count[0]);
                                invitedPeople.InsertRange(index, count);
                            }
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            if (invitedPeople.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", invitedPeople)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
