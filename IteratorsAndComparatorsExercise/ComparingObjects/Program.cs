using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                int age = int.Parse(commandArgs[1]);
                string town = commandArgs[2];
                Person person = new Person(name, age, town);

                people.Add(person);

                command = Console.ReadLine();
            }

            int personToCompare = int.Parse(Console.ReadLine());
            int countMatches = 0;
            int notEqual = 0;

            personToCompare--;

            for (int i = 0; i < people.Count; i++)
            {
                int equal = people[i].CompareTo(people[personToCompare]);
                if (equal == 0)
                {
                    countMatches++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (countMatches == 0 || countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {notEqual} {people.Count}");
            }
        }
    }
}
