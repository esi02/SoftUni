using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override int FoodEaten { get; set; }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
