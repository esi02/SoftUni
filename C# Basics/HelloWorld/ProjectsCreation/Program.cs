using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Името на архитекта - текст
            string nameOfTheArchitect = Console.ReadLine();
            //2.Брой на проектите -цяло число в интервала[0… 100]
            int numberOfProjects = int.Parse(Console.ReadLine());
            //Изчислението
            int timeNeeded = numberOfProjects * 3;
            //Принтиране
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeNeeded} hours to complete {numberOfProjects} project/s.");

        }
    }
}
