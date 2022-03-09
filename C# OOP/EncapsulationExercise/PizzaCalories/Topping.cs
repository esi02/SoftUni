using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;
        private double caloriespergram = 2;
        public double CaloriesPerGram
        {
            get => this.caloriespergram;
            private set => caloriespergram = value;
        }

        private string Type
        {
            get { return type; }
            set
            {
                if (char.IsLower(value[0]))
                {
                    value = value.ToLower();
                    if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                    {
                        throw new Exception($"Cannot place {value} on top of your pizza.");
                    }
                }
                else
                {
                    if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                    {
                        throw new Exception($"Cannot place {value} on top of your pizza.");
                    }
                }
                type = value;
            }
        }

        private double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public Topping(string type, double weight)
        {
            double typeModifier = 0;
            if (char.IsLower(type[0]))
            {
                this.Type = type.ToLower();
                switch (Type)
                {
                    case "meat":
                        typeModifier = 1.2;
                        break;
                    case "veggies":
                        typeModifier = 0.8;
                        break;
                    case "cheese":
                        typeModifier = 1.1;
                        break;
                    case "sauce":
                        typeModifier = 0.9;
                        break;
                }
            }
            else
            {
                this.Type = type;
                switch (Type)
                {
                    case "Meat":
                        typeModifier = 1.2;
                        break;
                    case "Veggies":
                        typeModifier = 0.8;
                        break;
                    case "Cheese":
                        typeModifier = 1.1;
                        break;
                    case "Sauce":
                        typeModifier = 0.9;
                        break;
                }
            }
            this.Weight = weight;
             
            CaloriesPerGram = 2 * (weight * typeModifier);
        }

    }
}
