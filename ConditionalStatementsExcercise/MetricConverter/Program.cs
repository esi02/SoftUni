using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToConvert = double.Parse(Console.ReadLine());
            string inputMetrics = Console.ReadLine();
            string outputMetrics = Console.ReadLine();

            double inputNumberInCentimeters = numberToConvert;
            if (inputMetrics == "mm")
            {
                inputNumberInCentimeters = numberToConvert / 10;
            }
            else if (inputMetrics == "m")
            {
                inputNumberInCentimeters = numberToConvert * 100;
            }

            double outputNumber = inputNumberInCentimeters;

            if (outputMetrics == "mm")
            {
                outputNumber = inputNumberInCentimeters * 10;
            }
            else if (outputMetrics == "m")
            {
                outputNumber = inputNumberInCentimeters / 100;
            }
            Console.WriteLine($"{outputNumber:f3}");
        }
    }
}
