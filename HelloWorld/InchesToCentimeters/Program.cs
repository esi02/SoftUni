using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = 2.54;
            double numberToConvert = double.Parse(Console.ReadLine());
            double resultInCentimeters = numberToConvert * inches;
            Console.WriteLine(resultInCentimeters);

        }
    }
}
