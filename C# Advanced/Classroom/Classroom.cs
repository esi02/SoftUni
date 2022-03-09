using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> students;
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return students.Count;
            }
            set
            {
                value = students.Count;
            }
        }
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            var exists = students.Exists(x => x.FirstName == firstName && x.LastName == lastName);
            if (exists)
            {
                var student = students.Find(x => x.FirstName == firstName && x.LastName == lastName);
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            var all = students.FindAll(x => x.Subject == subject);
            if (all.Count > 0)
            {
                StringBuilder result = new StringBuilder();

                result.AppendLine($"Subject: {subject}");
                result.AppendLine("Students:");

                foreach (var student in all)
                {
                    result.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return result.ToString().TrimEnd();
            }
            else
            {
                return $"No students enrolled for the subject";
            }
        }
        public int GetStudentsCount()
        {
            return students.Count;
        }
        public string GetStudent(string firstName, string lastName)
        {
            var student = students.Find(x => x.FirstName == firstName && x.LastName == lastName);
            return $"Student: First Name = {student.FirstName}, Last Name = {student.LastName}, Subject = {student.Subject}";
        }
    }
}
