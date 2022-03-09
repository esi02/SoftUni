using System;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public T value;
        public Box(T value)
        {
            this.value = value;
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> newBox = new Box<int>(input);
                Console.WriteLine($"{newBox.value.GetType()}: {newBox.value}");
            }
        }
    }
}
