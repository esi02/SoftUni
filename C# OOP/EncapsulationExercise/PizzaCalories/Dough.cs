using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double caloriespergram = 2;
        private double Weight
        {
            get { return weight; }
            set 
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        private string FlourType
        {
            get { return flourType; }
            set 
            {
                value = value.ToLower();
                if (value != "white" && value != "wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }
                flourType = value;
            }
        }
        private string BakingTechnique
        {
            get { return bakingTechnique; }
            set 
            {
                value = value.ToLower();
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new Exception("Invalid type of dough.");
                }
                bakingTechnique = value; 
            }
        }
        public double CaloriesPerGram 
        {
            get => this.caloriespergram;
            private set => caloriespergram = value;
        }


        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;

            double flourModifier = 0;
            double bakingModifier = 0;
            switch (FlourType)
            {
                case "white":
                    flourModifier = 1.5;
                    break;
                case "wholegrain":
                    flourModifier = 1;
                    break;
            }
            switch (BakingTechnique)
            {
                case "crispy":
                    bakingModifier = 0.9;
                    break;
                case "chewy":
                    bakingModifier = 1.1;
                    break;
                case "homemade":
                    bakingModifier = 1;
                    break;
            }
            CaloriesPerGram = (caloriespergram * weight) * flourModifier * bakingModifier;
        }
    }
}
