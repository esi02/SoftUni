using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int dislikedGrades = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblems = 0;
            double gradesSumForAverage = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;
            while (failedTimes < dislikedGrades)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSumForAverage += grade;
                solvedProblems++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {dislikedGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSumForAverage / solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
