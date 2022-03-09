using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class Box<T>
        where T : IComparable<T>
    {
        public List<T> list { get; set; }
        public Box()
        {
            list = new List<T>();
        }
        public int Count(T element)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int value = list[i].CompareTo(element);
                if (value > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> newList = new Box<double>();
            
            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                newList.list.Add(input);
            }

            double valueForComparison = double.Parse(Console.ReadLine());
            Console.WriteLine(newList.Count(valueForComparison));
        }
    }
}
