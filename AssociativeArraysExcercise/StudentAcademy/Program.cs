using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 1; i <= n; i++)
            {
                string student = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, new List<decimal> { grade });
                }
                else
                {
                    studentsGrades[student].Add(grade);
                }
            }

            Dictionary<string, decimal> averageGrades = new Dictionary<string, decimal>();

            foreach (var student in studentsGrades)
            {
                averageGrades.Add(student.Key, student.Value.Average());
            }

            var grades = averageGrades
                .Where(x => x.Value >= 4.50m)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
