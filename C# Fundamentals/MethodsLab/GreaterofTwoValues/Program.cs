using System;
using System.Linq;

namespace GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            GetMax(valueType);
        }

        static void GetMax(string valueType)
        {
            if (valueType == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Max(num1, num2));
            }
            else if (valueType == "char")
            {
                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());
                Console.WriteLine(char.ConvertFromUtf32(Math.Max(one, two)));
            }
            else
            {
                string strOne = Console.ReadLine();
                string strTwo = Console.ReadLine();
                if (strOne.CompareTo(strTwo) > 0)
                {
                    Console.WriteLine(strOne);
                }
                else
                {
                    Console.WriteLine(strTwo);
                }
            }
        }
    }
}
