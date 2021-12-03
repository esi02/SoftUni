using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            int result1 = this.Name.CompareTo(other.Name);
            if (result1 == 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            else
            {
                return result1;
            }

        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();      
        }
    }
}
