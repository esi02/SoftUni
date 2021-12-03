using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsInExam = int.Parse(Console.ReadLine());

            double topStudent = 0;
            double between4and499Student = 0;
            double between3and399Student = 0;
            double failedStudent = 0;
            double averageExamGrade = 0;
            for (int i = 1; i <= studentsInExam; i++)
            {
                double studentGrade = double.Parse(Console.ReadLine());
                averageExamGrade += studentGrade;
                if (studentGrade >= 2.00 && studentGrade <= 2.99)
                {
                    failedStudent++;
                }
                if (studentGrade >= 3.00 && studentGrade <= 3.99)
                {
                    between3and399Student++;
                }
                if (studentGrade >= 4.00 && studentGrade <= 4.99)
                {
                    between4and499Student++;
                }
                if (studentGrade >= 5.00)
                {
                    topStudent++;
                }
            }
            averageExamGrade /= studentsInExam;
            Console.WriteLine($"Top students: {topStudent / studentsInExam * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4and499Student / studentsInExam * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3and399Student / studentsInExam * 100:f2}%");
            Console.WriteLine($"Fail: {failedStudent / studentsInExam * 100:f2}%");
            Console.WriteLine($"Average: {averageExamGrade:f2}");
        }
    }
}
