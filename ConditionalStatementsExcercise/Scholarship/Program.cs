using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeInLv = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            //Social scholarship
            double socialScholarship = 0;
            if (incomeInLv < minimalSalary && averageGrade >= 4.50)
            {
                socialScholarship = Math.Floor(minimalSalary * 0.35);
            }
            //Excellent grade scholarhship
            double excellentGradeScholarship = 0;
            if (averageGrade >= 5.50)
            {
                excellentGradeScholarship = Math.Floor(averageGrade * 25);
            }
            if (socialScholarship == 0 && excellentGradeScholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship > 0 && excellentGradeScholarship > 0)
            {
                if (socialScholarship > excellentGradeScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentGradeScholarship} BGN");
                }
            }
            else if (socialScholarship > 0)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (excellentGradeScholarship > 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentGradeScholarship} BGN");
            }
        }
    }
}
