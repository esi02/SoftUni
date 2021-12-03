using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesOfBiscuits = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "No More Money")
            {
                string[] commandArgs = command.Split();

                string action = commandArgs[0];
                if (action == "OutOfStock")
                {
                    string biscuit = commandArgs[1];
                    if (namesOfBiscuits.Contains(biscuit))
                    {
                        for (int i = 0; i < namesOfBiscuits.Count; i++)
                        {
                            if (namesOfBiscuits[i] == biscuit)
                            {
                                namesOfBiscuits[i] = "None";
                            }
                        }

                    }
                }
                else if (action == "Required")
                {
                    string biscuit = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    if (index >= 0 && index < namesOfBiscuits.Count && namesOfBiscuits[index] != "None")
                    {
                        namesOfBiscuits[index] = biscuit;
                    }
                }
                else if (action == "Last")
                {
                    string biscuit = commandArgs[1];
                    namesOfBiscuits.Add(biscuit);
                }

                command = Console.ReadLine();
            }

            namesOfBiscuits = namesOfBiscuits.FindAll(x => x != "None");
            Console.WriteLine(string.Join(" ", namesOfBiscuits));
        }
    }
}
