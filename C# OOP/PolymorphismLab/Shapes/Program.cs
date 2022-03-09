using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Rectangle tangle = new Rectangle(height, width);
            Console.WriteLine(tangle.Draw());
            int radius = int.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine(circle.Draw());
        }
    }
}
