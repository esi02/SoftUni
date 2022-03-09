using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class ClassList<T>
    {
        public List<T> List { get; set; }
        public ClassList()
        {
            List = new List<T>();
        }
        public T Swap(int firstIndex, int secondIndex)
        {
            var firstElement = List.ElementAt(firstIndex);
            var secondElement = List.ElementAt(secondIndex);
            List[secondIndex] = firstElement;
            List[firstIndex] = secondElement;
            return default;
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ClassList<int> list = new ClassList<int>();

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.List.Add(input);
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int firstIndex = int.Parse(command[0]);
            int secondIndex = int.Parse(command[1]);

            list.Swap(firstIndex, secondIndex);

            foreach (var name in list.List)
            {
                Console.WriteLine($"{name.GetType()}: {name}");
            }
        }
    }
}
