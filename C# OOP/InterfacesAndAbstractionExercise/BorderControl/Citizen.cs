using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private int defaultFood = 0;
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; }
        public string Birthdate { get; set; }
        public int Food 
        {
            get => this.defaultFood;
            set => this.defaultFood = value;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
