using System;
using System.Collections.Generic;
using System.Linq;
namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> path = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var lake = new Lake(path);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
