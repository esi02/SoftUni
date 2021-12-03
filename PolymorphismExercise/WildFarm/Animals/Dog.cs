using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
