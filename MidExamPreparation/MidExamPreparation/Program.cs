using System;

namespace MidExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double countOfAttendances = 0;
            double maxBonus = 0;
            double totalBonus = 0;
            int bestStudentAttendances = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                countOfAttendances = double.Parse(Console.ReadLine());
                totalBonus = countOfAttendances / (double)countOfLectures * (5 + initialBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    bestStudentAttendances = (int)countOfAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {bestStudentAttendances} lectures.");
        }
    }
}
