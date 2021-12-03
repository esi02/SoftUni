using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
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

                Student currentStudent = new Student();

                currentStudent.firstName = current[0];
                currentStudent.lastName = current[1];
                currentStudent.age = int.Parse(current[2]);
                currentStudent.hometown = current[3];

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
    }
    class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public string hometown;
    }
}
