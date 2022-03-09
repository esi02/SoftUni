using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Snake snake = new Snake("snake");
            Console.WriteLine(snake.Name);
            Bear bear = new Bear("bear");
            Console.WriteLine(bear.Name);
            Animal smth = new Animal("something");
        }
    }
}