using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        private int defaultFood = 0;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food
        {
            get => defaultFood;
            set => defaultFood = value;
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
