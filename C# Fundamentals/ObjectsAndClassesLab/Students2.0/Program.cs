using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> studentList = new List<Student>();

            while (command != "end")
            {
                string[] current = command
                    .Split()
                    .ToArray();

                string firstName = current[0];
                string lastName = current[1];
                int age = int.Parse(current[2]);
                string hometown = current[3];

                Student currentStudent = new Student();

                currentStudent.firstName = firstName;
                currentStudent.lastName = lastName;
                currentStudent.age = age;
                currentStudent.hometown = hometown;
                if (IsStudentExisting(studentList, firstName, lastName))
                {
                    currentStudent = GetStudent(studentList, firstName, lastName);
                    currentStudent.age = age;
                    currentStudent.hometown = hometown;
                    command = Console.ReadLine();
                    continue;
                }

                studentList.Add(currentStudent);

                command = Console.ReadLine();
            }

            string nameOfCity = Console.ReadLine();
            List<Student> filtered = studentList
                .Where(s => s.hometown == nameOfCity)
                .ToList();

            foreach (Student student in filtered)
            {
                Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
            }

        }
        static bool IsStudentExisting(List<Student> studentList, string firstName, string lastName)
        {
            foreach (Student student in studentList)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> studentList, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in studentList)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
    class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string hometown;
    }

}
