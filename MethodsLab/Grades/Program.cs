using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grades(grade);
        }

        static void Grades(double grade)
        {
            bool isFailed = grade >= 2.00 && grade <= 2.99;
            bool isPoor = grade >= 3.00 && grade <= 3.49;
            bool isGood = grade >= 3.50 && grade <= 4.49;
            bool isVeryGood = grade >= 4.50 && grade <= 5.49;

            if (isFailed)
            {
                Console.WriteLine("Fail");
            }
            else if (isPoor)
            {
                Console.WriteLine("Poor");
            }
            else if (isGood)
            {
                Console.WriteLine("Good");
            }
            else if (isVeryGood)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
