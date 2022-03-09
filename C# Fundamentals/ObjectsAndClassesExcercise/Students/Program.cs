using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                var studentsList = new Student(command[0], command[1], double.Parse(command[2]));

                students.Add(studentsList);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstname, string lastname, double grade)
        {
            firstName = firstname;
            lastName = lastname;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}: {Grade:f2}";
        }
    }
}
