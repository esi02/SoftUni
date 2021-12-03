using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }

        public Hen(string name, double weight, string livingRegion, int wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }

        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }

        public override string ProduceSound()
        {
            return "Cluck";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
