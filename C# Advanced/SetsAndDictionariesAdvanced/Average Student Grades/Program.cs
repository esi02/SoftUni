using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>();

            for (int i = 1; i <= n; i++)
            {
                string[] read = Console.ReadLine().Split();
                string name = read[0];
                decimal grade = decimal.Parse(read[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<decimal>() { grade });
                }
            }

            foreach (var person in students)
            {
                Console.Write($"{person.Key} -> ");
                foreach (var grade in person.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {person.Value.Average():f2})");
            }
        }
    }
}
