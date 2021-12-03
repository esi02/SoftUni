using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(new Person() { Name = name, Age = age });
            }
            string condition = Console.ReadLine();
            int ageToCompare = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = x => true;

            if (condition == "younger")
            {
                filter = x => x.Age < ageToCompare;
            }
            else if (condition == "older")
            {
                filter = x => x.Age >= ageToCompare;
            }

            var filtered = people.Where(filter);

            foreach (var person in filtered)
            {
                if (format == "name")
                {
                    Console.WriteLine(person.Name);
                }
                else if (format == "age")
                {
                    Console.WriteLine(person.Age);
                }
                else if (format == "name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
}
