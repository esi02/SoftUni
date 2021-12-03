using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bagOfProducts;
        public List<Product> Bag { get => this.bagOfProducts; private set => this.bagOfProducts = value; }
        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Money 
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }
    }
}
