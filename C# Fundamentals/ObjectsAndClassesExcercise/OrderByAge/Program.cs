using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();
            while (input != "End")
            {
                string[] array = input
                    .Split()
                    .ToArray();

                string name = array[0];
                string ID = array[1];
                int age = int.Parse(array[2]);
                Person newPerson = new Person();
                newPerson.Name = name;
                newPerson.ID = ID;
                newPerson.Age = age;

                people.Add(newPerson);

                input = Console.ReadLine();
            }
            people = people
                .OrderBy(x => x.Age)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
    class Person
    {
        public string Name;
        public string ID;
        public int Age;

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}

