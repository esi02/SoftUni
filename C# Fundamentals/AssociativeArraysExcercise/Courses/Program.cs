using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] commandArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = commandArgs[0];
                string student = commandArgs[1];

                if (courses.ContainsKey(course))
                {
                    courses[course].Add(student);
                }
                else
                {
                    courses.Add(course, new List<string> { student });
                }

                command = Console.ReadLine();
            }

            courses = courses
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, 
                              x => x.Value);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    var contest = course.Value.OrderBy(x => x).ToList();
                    Console.WriteLine($"-- {contest[i]}");
                }
            }
        }
    }
}
