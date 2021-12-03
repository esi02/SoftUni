using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Animal> animals = new List<Animal>();
            List<string> validTypes = new List<string>
            {
                "Cat",
                "Dog",
                "Frog",
                "Kitten",
                "Tomcat"
            };

            while (input != "Beast!")
            {
                string[] argum = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = argum[0];
                int age = int.Parse(argum[1]);
                string gender = argum[2];

                if (!validTypes.Any(x => x == input) || gender != "Male" && gender != "Female" || age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                if (input == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (input == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    animals.Add(dog);
                }
                else if (input == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                else if (input == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    animals.Add(kitten);
                }
                else if (input == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                }
                input = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
