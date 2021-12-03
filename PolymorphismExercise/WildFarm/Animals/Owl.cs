using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int wingSize)
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
            return "Hoot Hoot";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
