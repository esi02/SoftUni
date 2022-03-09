using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;
        private double totalCalories;
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
            
        }

        public double TotalCalories => this.totalCalories;

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }


        public List<Topping> Toppings
        {
            get { return toppings; }
            private set 
            {
                toppings = value;
            }
        }


        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
            if (Toppings.Count < 0 || Toppings.Count > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            this.totalCalories = Dough.CaloriesPerGram + Toppings.Sum(x => x.CaloriesPerGram);
        }
    }
}
