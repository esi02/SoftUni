using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> people;
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            int oldest = int.MinValue;
            string oldestName = string.Empty;
            foreach (var person in people)
            {
                if (person.Age > oldest)
                {
                    oldest = person.Age;
                    oldestName = person.Name;
                }
            }
            return people.Find(x => x.Name == oldestName);
        }
    }
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }
        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person(int age)
        {
            name = "No name";
            this.age = age;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            family.people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                Person person = new Person();
                person.Name = name;
                person.Age = age;
                family.people.Add(person);
            }

            var toPrint = family.people.Where(x => x.Age > 30).OrderBy(x => x.Name);
            foreach (var person in toPrint)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
