using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int grades = 1;
            double sumGrades = 0;
            int excludedTimes = 0;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    excludedTimes++;
                    if (excludedTimes > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grades} grade");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                sumGrades += grade;
                grades++;
            }
            double averageGrade = sumGrades / 12;
            //понеже ученика може да има само шестици и после само двойки, средния успех може да е над 4 обаче все пак да се провали, затова е по-правилно да сложим пътите в които се е провалил да са по-малко от 1
            if (excludedTimes < 1)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
