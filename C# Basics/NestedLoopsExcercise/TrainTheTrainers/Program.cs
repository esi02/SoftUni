using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNum = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double averageGrade = 0;
            double totalAverageGrade = 0;
            int presentationCount = 0;

            while (presentation != "Finish")
            {
                presentationCount++;
                double grade = 0;
                for (int i = 1; i <= juryNum; i++)
                {
                    grade += double.Parse(Console.ReadLine());

                }
                averageGrade = grade / juryNum;
                totalAverageGrade += averageGrade;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                presentation = Console.ReadLine();
            }
            totalAverageGrade /= presentationCount;
            Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");
        }
    }
}
