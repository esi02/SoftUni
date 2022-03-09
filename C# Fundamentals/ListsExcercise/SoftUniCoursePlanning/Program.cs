using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandArgs = command.Split(":");
                string action = commandArgs[0];
                string lesson = commandArgs[1];

                if (action == "Add")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Insert(index, lesson);
                    }
                }
                else if (action == "Remove")
                {
                    if (schedule.Contains(lesson))
                    {
                        schedule.Remove(lesson);
                    }
                    if (schedule.Contains($"{lesson}-Exercise"))
                    {
                        schedule.Remove($"{lesson}-Exercise");
                    }
                }
                else if (action == "Swap")
                {
                    string secondLesson = commandArgs[2];
                    int indexOfFirstLesson = schedule.IndexOf(lesson);
                    int indexOfSecondLesson = schedule.IndexOf(secondLesson);

                    if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
                    {
                        schedule.Insert(indexOfFirstLesson, secondLesson);
                        schedule.RemoveAt(indexOfFirstLesson + 1);
                        //добавяме на новите места, след което трием на старите
                        schedule.Insert(indexOfSecondLesson, lesson);
                        schedule.RemoveAt(indexOfSecondLesson + 1);
                    }
                    //отново намираме индексите, понеже разменяме местата на уроците
                    indexOfFirstLesson = schedule.IndexOf(lesson);
                    indexOfSecondLesson = schedule.IndexOf(secondLesson);

                    if (schedule.Contains($"{lesson}-Exercise"))
                    {
                        schedule.Remove($"{lesson}-Exercise");
                        if (indexOfFirstLesson < schedule.Count)
                        {
                            schedule.Insert(indexOfFirstLesson + 1, $"{lesson}-Exercise");
                        }
                        else
                        {
                            schedule.Add($"{lesson}-Exercise");
                        }
                    }
                    if (schedule.Contains($"{secondLesson}-Exercise"))
                    {
                        schedule.Remove($"{secondLesson}-Exercise");
                        if (indexOfSecondLesson < schedule.Count)
                        {
                            schedule.Insert(indexOfSecondLesson + 1, $"{secondLesson}-Exercise");
                        }
                        else
                        {
                            schedule.Add($"{secondLesson}-Exercise");
                        }
                    }
                }
                else if (action == "Exercise")
                {
                    if (schedule.Contains(lesson) && !schedule.Contains($"{lesson}-Exercise"))
                    {
                        if (schedule.IndexOf(lesson) < schedule.Count)
                        {
                            schedule.Insert(schedule.IndexOf(lesson + 1), "-Exercise");
                        }
                        else
                        {
                            schedule.Add($"{lesson}-Exercise");
                        }
                    }
                    else
                    {
                        schedule.Add(lesson);
                        schedule.Add($"{lesson}-Exercise");
                    }
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
