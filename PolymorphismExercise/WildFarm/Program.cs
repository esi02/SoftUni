using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int linesCount = 0;
            Animal animal = null;
            Food food = null;
            List<Animal> animals = new List<Animal>();

            while (input != "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (linesCount % 2 == 0)
                {
                    string type = inputArgs[0];
                    if (type == "Cat" || type == "Tiger")
                    {
                        string name = inputArgs[1];
                        double weight = double.Parse(inputArgs[2]);
                        string livingRegion = inputArgs[3];
                        string breed = inputArgs[4];
                        animal = CreateFeline(type, name, weight, livingRegion, breed);
                    }
                    else if (type == "Owl" || type == "Hen")
                    {
                        string name = inputArgs[1];
                        double weight = double.Parse(inputArgs[2]);
                        int wingSize = int.Parse(inputArgs[3]);
                        animal = CreateBird(type, name, weight, wingSize);
                    }
                    else if (type == "Mouse" || type == "Dog")
                    {
                        string name = inputArgs[1];
                        double weight = double.Parse(inputArgs[2]);
                        string livingRegion = inputArgs[3];
                        animal = CreateMammal(type, name, weight, livingRegion);
                    }

                    animals.Add(animal);
                }
                else
                {
                    string foodType = inputArgs[0];
                    int quantity = int.Parse(inputArgs[1]);
                    string animalType = animal.GetType().Name;
                    Console.WriteLine(animal.ProduceSound());
                    if (animalType == "Hen")
                    {
                        food = CreateFood(foodType, quantity);
                        animal.FoodEaten = quantity;
                        animal.Weight += 0.35 * animal.FoodEaten;
                    }
                    else if (animalType == "Owl")
                    {
                        if (foodType == "Meat")
                        {
                            food = CreateFood(foodType, quantity);
                            animal.FoodEaten = quantity;
                            animal.Weight += 0.25 * animal.FoodEaten;
                        }
                        else
                        {
                            Console.WriteLine($"{animalType} does not eat {foodType}!");
                        }
                    }
                    else if (animalType == "Mouse")
                    {
                        if (foodType == "Vegetable" || foodType == "Fruit")
                        {
                            food = CreateFood(foodType, quantity);
                            animal.FoodEaten = quantity;
                            animal.Weight += 0.10 * animal.FoodEaten;
                        }
                        else
                        {
                            Console.WriteLine($"{animalType} does not eat {foodType}!");
                        }
                    }
                    else if (animalType == "Cat")
                    {
                        if (foodType == "Vegetable" || foodType == "Meat")
                        {
                            food = CreateFood(foodType, quantity);
                            animal.FoodEaten = quantity;
                            animal.Weight += 0.30 * animal.FoodEaten;
                        }
                        else
                        {
                            Console.WriteLine($"{animalType} does not eat {foodType}!");
                        }
                    }
                    else if (animalType == "Dog")
                    {
                        if (foodType == "Meat")
                        {
                            food = CreateFood(foodType, quantity);
                            animal.FoodEaten = quantity;
                            animal.Weight += 0.40 * quantity;
                        }
                        else
                        {
                            Console.WriteLine($"{animalType} does not eat {foodType}!");
                        }
                    }
                    else if (animalType == "Tiger")
                    {
                        if (foodType == "Meat")
                        {
                            food = CreateFood(foodType, quantity);
                            animal.FoodEaten = quantity;
                            animal.Weight = 1 * quantity;
                        }
                        else
                        {
                            Console.WriteLine($"{animalType} does not eat {foodType}!");
                        }
                    }

                }

                linesCount++;

                input = Console.ReadLine();
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Food CreateFood(string type, int quantity)
        {
            Food food = null;
            switch (type)
            {
                case "Vegetable":
                    food = new Vegetable(quantity);
                    break;
                case "Fruit":
                    food = new Fruit(quantity);
                    break;
                case "Meat":
                    food = new Meat(quantity);
                    break;
                case "Seeds":
                    food = new Seeds(quantity);
                    break;
            }
            return food;
        }
        public static Feline CreateFeline(string type, string name, double weight, string livingRegion, string breed)
        {
            Feline feline = null;
            switch (type)
            {
                case "Cat":
                    feline = new Cat(name, weight, livingRegion, breed);
                    break;
                case "Tiger":
                    feline = new Tiger(name, weight, livingRegion, breed);
                    break;
            }
            return feline;
        }
        public static Bird CreateBird(string type, string name, double weight, int wingSize)
        {
            Bird bird = null;
            switch (type)
            {
                case "Owl":
                    bird = new Owl(name, weight, wingSize);
                    break;
                case "Hen":
                    bird = new Hen(name, weight, wingSize);
                    break;
            }
            return bird;
        }
        public static Mammal CreateMammal(string type, string name, double weight, string livingRegion)
        {
            Mammal mammal = null;
            switch (type)
            {
                case "Mouse":
                    mammal = new Mouse(name, weight, livingRegion);
                    break;
                case "Dog":
                    mammal = new Dog(name, weight, livingRegion);
                    break;
            }
            return mammal;
        }
    }
}
