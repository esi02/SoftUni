using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string people = Console.ReadLine();
            string products = Console.ReadLine();

            string[] peopleArgs = people.Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsArgs = products.Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> peoples = new List<Person>();
            List<Product> products1 = new List<Product>();
            Person person = null;
            Product product = null;

            for (int i = 0; i < peopleArgs.Length; i++)
            {
                string[] temp = peopleArgs[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string personName = temp[0];
                int personMoney = int.Parse(temp[1]);
                try
                {
                    person = new Person(personName, personMoney);
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
                peoples.Add(person);
            }

            for (int i = 0; i < productsArgs.Length; i++)
            {
                string[] temp = productsArgs[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productName = temp[0];
                int productCost = int.Parse(temp[1]);
                try
                {
                    product = new Product(productName, productCost);
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
                products1.Add(product);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tt = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personToBuy = tt[0];
                string productToBuy = tt[1];

                var foundPerson = peoples.Find(x => x.Name == personToBuy);
                var foundProduct = products1.Find(x => x.Name == productToBuy);

                if (foundPerson.Money >= foundProduct.Cost)
                {
                    foundPerson.Bag.Add(foundProduct);
                    foundPerson.Money -= foundProduct.Cost;
                    Console.WriteLine($"{foundPerson.Name} bought {foundProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{foundPerson.Name} can't afford {foundProduct.Name}");
                }

                input = Console.ReadLine();
            }

            foreach (var person1 in peoples)
            {
                var bagg = new List<string>();
                foreach (var item in person1.Bag)
                {
                    bagg.Add(item.Name);
                }

                if (person1.Bag.Count == 0)
                {
                    Console.WriteLine($"{person1.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person1.Name} - {string.Join(", ", bagg)}");
                }
            }
        }
    }
}
