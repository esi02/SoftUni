using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = commandArgs[0];
                string employeeId = commandArgs[1];

                if (employees.ContainsKey(company))
                {
                    if (!employees[company].Contains(employeeId))
                    {
                        employees[company].Add(employeeId);
                    }
                }
                else
                {
                    employees.Add(company, new List<string> { employeeId });
                }

                command = Console.ReadLine();
            }

            employees = employees.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var company in employees)
            {
                Console.WriteLine($"{company.Key}");
                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}
