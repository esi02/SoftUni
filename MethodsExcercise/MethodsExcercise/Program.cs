using System;
using System.Linq;

namespace MethodsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            PrintSmallest(n1, n2, n3);
        }

        static int PrintSmallest(int n1, int n2, int n3)
        {
            int theSmallest = 0;
            if (n1 < n2 && n1 < n3)
            {
                theSmallest = n1;
                Console.WriteLine(n1);
            }
            else if (n2 < n1 && n2 < n3)
            {
                theSmallest = n2;
                Console.WriteLine(n2);
            }
            else
            {
                theSmallest = n3;
                Console.WriteLine(n3);
            }
            return theSmallest;
        }
    }
}
