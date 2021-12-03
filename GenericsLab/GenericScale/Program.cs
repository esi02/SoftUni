using System;
using System.Collections.Generic;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var scale1 = new EqualityScale<int>(5, 10);
            Console.WriteLine(scale1.GetHeavier());

            var scale2 = new EqualityScale<string>("Man", "Woman");
            Console.WriteLine(scale2.GetHeavier());
        }
    }
}


